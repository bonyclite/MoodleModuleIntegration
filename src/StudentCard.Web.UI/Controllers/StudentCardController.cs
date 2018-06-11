using System;
using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using StudentCard.Web.UI.Models.StudentCard.AcademicDebts;
using StudentCard.Web.UI.Models.StudentCard.Details;
using StudentCard.Web.UI.Models.StudentCard.Front;
using StudentCard.Web.UI.Models.StudentCard.Marks;
using Web.Common.App.Extensions;
using DisciplineModel = StudentCard.Web.UI.Models.StudentCard.Marks.DisciplineModel;

namespace StudentCard.Web.UI.Controllers
{
    public class StudentCardController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programms> MdlBlockDofSProgrammsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_contracts> MdlBlockDofSContractsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmsbcs> MdlBlockDofSProgrammsbcsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_ages> MdlBlockDofSAgesRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cpassed> MdlBlockDofSCpassedRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_study_document> MdlStudyDocumentRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_items> MdlGradeItemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_course> MdlCourseRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_makeup_academicdebt> MdlMakeupAcademicdebtRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_grades> MdlGradeGradesRepository { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(long personId)
        {
            var studyDocument =
                MdlStudyDocumentRepository.FirstOrDefault(e => e.isnew && e.isapproved && e.studentid == personId);

            if (studyDocument != null)
            {
                TempData["Message"] = "Ваша справка об обучении готова";
                studyDocument.isnew = false;

                MdlStudyDocumentRepository.Save(studyDocument);
                MdlStudyDocumentRepository.Commit();
            }

            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            var semesters = MdlBlockDofSAgesRepository.GetAll().ToArray();

            var student = MdlBlockDofSPersonsRepository.GetById(personId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);

            foreach (var semester in semesters)
            {
                var cstreamses = MdlBlockDofSCstreamsRepository
                    .GetMany(e => e.departmentid == department.id && e.ageid == semester.id)
                    .ToArray();

                if (cstreamses.Any())
                {
                    foreach (var cstreamse in cstreamses)
                    {
                        var df = MdlBlockDofSCpassedRepository.GetMany(e =>
                            e.programmitemid == cstreamse.programmitemid && e.studentid == personId).ToArray();

                        if (MdlBlockDofSCpassedRepository.Any(e =>
                            e.programmitemid == cstreamse.programmitemid && e.studentid == personId))
                        {
                            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(cstreamse.programmitemid.Value);
                            var gradeItem = MdlGradeItemsRepository
                                .FirstOrDefault(e => e.courseid == programmItem.mdlcourse && e.locktime < now && e.itemtype == "manual");

                            if (gradeItem != null)
                            {
                                if (MdlMakeupAcademicdebtRepository.Any(e => e.studentid == student.id && e.gradeitemid == gradeItem.id && e.isnew))
                                {
                                    var course = MdlCourseRepository.GetById(gradeItem.courseid.Value);
                                    TempData["WarningMessage"] +=
                                        $"Вы имеете задолжность по {course.fullname}.<a href='{this.BuildUrlFromExpression(c => c.AcademicDebts(personId))}'>Нажмите для просмотра</a>";
                                }
                            }
                        }
                    }
                }
            }

            var academicdebts = MdlMakeupAcademicdebtRepository.GetMany(e =>
                e.studentid == student.id && e.date != null && e.isteacherapproved && e.isnew && e.isdepartamentapproved).ToArray();

            if (academicdebts.Any())
            {
                foreach (var academicdebt in academicdebts)
                {
                    var gradeItem = MdlGradeItemsRepository.GetById(academicdebt.gradeitemid);
                    var course = MdlCourseRepository.GetById(gradeItem.courseid.Value);

                    TempData["InfoMessage"] +=
                        $"Вам назначена пересдача по {course.fullname} на {academicdebt.date.Value:F}";
                }
            }

            return View(new StudentCardDetailsModel
            {
                PersonId = personId
            });
        }

        [ChildActionOnly]
        public ActionResult Front(long personId)
        {
            var student = MdlBlockDofSPersonsRepository.GetById(personId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);
            var contractId = MdlBlockDofSContractsRepository.SingleOrDefault(e => e.studentid == personId, e => e.id);
            var programmId =
                MdlBlockDofSProgrammsbcsRepository.SingleOrDefault(e => e.contractid == contractId,
                    e => e.programmid.Value);
            var programm = MdlBlockDofSProgrammsRepository.GetById(programmId);

            return PartialView("~/Views/StudentCard/Front.cshtml", new StudentCardFrontModel
            {
                DepartamentName = department.name,
                ProgrammName = programm.name,
                StudentModel = new StudentModel
                {
                    FirstName = student.firstname,
                    MiddleName = student.middlename,
                    LastName = student.lastname,
                    Email = student.email,
                    PhoneHome = student.phonehome,
                    PhoneNumber = student.phonecell
                }
            });
        }

        [ChildActionOnly]
        public ActionResult Marks(long personId)
        {
            var semesters = MdlBlockDofSAgesRepository.GetAll().ToArray();

            var student = MdlBlockDofSPersonsRepository.GetById(personId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);

            var model = new StudentCardMarksModel();

            foreach (var semester in semesters)
            {
                var cstreamses = MdlBlockDofSCstreamsRepository
                    .GetMany(e => e.departmentid == department.id && e.ageid == semester.id)
                    .ToArray();

                if (cstreamses.Any())
                {
                    var semesterModel = new SemesterModel
                    {
                        Name = semester.name
                    };

                    foreach (var cstreamse in cstreamses)
                    {
                        if (MdlBlockDofSCpassedRepository.Any(e =>
                            e.programmitemid == cstreamse.programmitemid && e.studentid == personId))
                        {
                            var programmItem =
                                MdlBlockDofSProgrammitemsRepository.GetById(cstreamse.programmitemid.Value);

                            var gradeItem = MdlGradeItemsRepository.FirstOrDefault(e =>
                                e.courseid == programmItem.mdlcourse && e.itemtype == "manual");

                            string mark = null;

                            if (gradeItem != null)
                            {
                                var gradeses = MdlGradeGradesRepository.FirstOrDefault(e => e.itemid == gradeItem.id && e.userid == student.mdluser);
                                mark = gradeses.finalgrade.ToString();
                            }

                            semesterModel.Disciplines.Add(new DisciplineModel
                            {
                                Code = cstreamse.name,
                                Hours = cstreamse.hours,
                                Name = programmItem.name,
                                Mark = mark
                            });
                        }
                    }

                    if (semesterModel.Disciplines.Any())
                        model.Semesters.Add(semesterModel);
                }
            }

            return PartialView("~/Views/StudentCard/Marks.cshtml", model);
        }

        [HttpGet]
        public ActionResult AcademicDebts(long studentId)
        {
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            var semesters = MdlBlockDofSAgesRepository.GetAll().ToArray();

            var student = MdlBlockDofSPersonsRepository.GetById(studentId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);

            var model = new StudentCardAcademicDebtsViewModel
            {
                StudentId = studentId
            };

            foreach (var semester in semesters)
            {
                var cstreamses = MdlBlockDofSCstreamsRepository
                    .GetMany(e => e.departmentid == department.id && e.ageid == semester.id)
                    .ToArray();

                if (cstreamses.Any())
                {
                    foreach (var cstreamse in cstreamses)
                    {
                        if (MdlBlockDofSCpassedRepository.Any(e => e.programmitemid == cstreamse.programmitemid && e.studentid == studentId))
                        {
                            var programmItem =
                                MdlBlockDofSProgrammitemsRepository.GetById(cstreamse.programmitemid.Value);

                            var gradeItems = MdlGradeItemsRepository.GetMany(e =>
                                e.courseid == programmItem.mdlcourse && e.locktime < now && e.itemtype == "manual");

                            foreach (var gradeItem in gradeItems)
                            {
                                var course = MdlCourseRepository.GetById(gradeItem.courseid.Value);

                                model.Disciplines.Add(new StudentCardAcademicDebtsViewModel.DisciplineModel
                                {
                                    GradeItemId = gradeItem.id,
                                    DisciplineName = course.fullname
                                });
                            }
                        }
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AcademicDebts(StudentCardAcademicDebtsModel model)
        {
            foreach (var gradeItemId in model.GradeItemIds)
            {
                MdlMakeupAcademicdebtRepository.Save(new mdl_makeup_academicdebt
                {
                    studentid = model.StudentId,
                    isdepartamentapproved = false,
                    isteacherapproved = false,
                    isnew = true,
                    gradeitemid = gradeItemId
                });
            }

            MdlMakeupAcademicdebtRepository.Commit();

            TempData["Message"] = "Ваш запрос на пересдачу успешно отправлен";

            return RedirectToAction("Details", new { personId = model.StudentId });
        }
    }
}