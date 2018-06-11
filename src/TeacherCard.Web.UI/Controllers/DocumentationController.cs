using System;
using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using TeacherCard.Web.UI.App;
using TeacherCard.Web.UI.Models.Discipline.List;
using TeacherCard.Web.UI.Models.Documentation.MakeUpAcademicDebts;
using Web.Common.App.Extensions;

namespace TeacherCard.Web.UI.Controllers
{
    public class DocumentationController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_study_document> MdlStudyDocumentRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_makeup_academicdebt> MdlMakeupAcademicdebtRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_agroups> MdlBlockDofSAgroupsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_items> MdlGradeItemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_grades> MdlGradeGradesRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmsbcs> MdlBlockDofSProgrammsbcsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_contracts> MdlBlockDofSContractsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }

        [HttpGet]
        public ActionResult MakeUpAllAcademicDebtDocuments()
        {
            var teacher = MdlBlockDofSPersonsRepository.FirstOrDefault(e => e.mdluser == Consts.MdlUser);

            var cstreamses = MdlBlockDofSCstreamsRepository.GetMany(e => e.teacherid == teacher.id).ToArray();

            var ids = cstreamses.Select(c => c.programmitemid);

            var disciplinesFrom3KL = MdlBlockDofSProgrammitemsRepository
                .GetMany(e => ids.Contains(e.id))
                .ToArray();

            return View(new DisciplineListModel
            {
                Disciplines = disciplinesFrom3KL.Select(e => new Models.Discipline.List.DisciplineModel
                {
                    MdlCourse = e.mdlcourse.Value,
                    ProgrammItemId = e.id,
                    Name = e.name
                })
            });
        }

        [HttpGet]
        public ActionResult MakeUpAcademicDebtDocuments(long programmItemId)
        {
            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(programmItemId);

            var model = new DocumentationMakeUpAcademicDebtDocumentsModel
            {
                ProgrammItemId = programmItemId,
                DisciplineName = programmItem.name
            };

            var groups = MdlBlockDofSAgroupsRepository.GetMany(e => e.departmentid == programmItem.departmentid)
                .ToArray();

            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var gradeItem = MdlGradeItemsRepository.FirstOrDefault(e =>
                e.courseid == programmItem.mdlcourse && e.locktime < now && e.itemtype == "manual");
            var gradeses = MdlGradeGradesRepository.GetMany(e => e.itemid == gradeItem.id).ToArray();

            foreach (var group in groups)
            {
                var academicdebtsInfo = MdlMakeupAcademicdebtRepository
                    .GetMany(e => e.isnew && e.isdepartamentapproved, e => new
                    {
                        e.studentid,
                        e.date
                    })
                    .ToArray();

                var studentIds = academicdebtsInfo.Select(a => a.studentid);

                foreach (var item in gradeses)
                {
                    if (item.finalgrade == null)
                    {
                        var student = MdlBlockDofSPersonsRepository.FirstOrDefault(e =>
                            studentIds.Contains(e.id) && e.mdluser == item.userid);

                        if (student != null)
                        {
                            model.AcademicDebtDocumentModels.Add(new AcademicDebtDocumentModel
                            {
                                Id = student.id,
                                FirstName = student.firstname,
                                LastName = student.lastname,
                                MdlUser = student.mdluser.Value,
                                MiddleName = student.middlename,
                                GroupId = group.id,
                                GradeId = item.id,
                                GroupName = group.name,
                                Date = academicdebtsInfo.First().date.Value,
                                DisciplineModel = new Models.Documentation.MakeUpAcademicDebts.DisciplineModel
                                {
                                    Id = programmItem.id,
                                    Name = programmItem.name
                                }
                            });
                        }
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult MakeUpAcademicDebtDocuments(DocumentationMakeUpAcademicDebtDocumentsModel model)
        {
            foreach (var documentModel in model.AcademicDebtDocumentModels)
            {
                if (documentModel.Mark != null)
                {
                    var grade = MdlGradeGradesRepository.GetById(documentModel.GradeId);
                    grade.finalgrade = documentModel.Mark;

                    MdlGradeGradesRepository.Save(grade);

                    var academicdebt = MdlMakeupAcademicdebtRepository.FirstOrDefault(e =>
                        e.studentid == documentModel.Id && e.date == documentModel.Date);

                    academicdebt.isnew = false;

                    MdlMakeupAcademicdebtRepository.Save(academicdebt);
                }
            }

            MdlGradeGradesRepository.Commit();
            MdlMakeupAcademicdebtRepository.Commit();

            TempData["Message"] = "Оценки успешно обновлены";

            return RedirectToAction("MakeUpAcademicDebtDocuments", new { programmItemId = model.ProgrammItemId });
        }
    }
}