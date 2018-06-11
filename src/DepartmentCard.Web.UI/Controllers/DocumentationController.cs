using System;
using System.Linq;
using System.Web.Mvc;
using DepartmentCard.Web.UI.Models.Documentation.CreateMakeUpAcademicDebtDocuments;
using DepartmentCard.Web.UI.Models.Documentation.MakeUpAcademicDebtDocuments;
using DepartmentCard.Web.UI.Models.Documentation.StudyDocuments;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using Web.Common.App.Extensions;

namespace DepartmentCard.Web.UI.Controllers
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

        [HttpGet]
        public ActionResult StudyDocuments()
        {
            var studyDocumentInfos =
                MdlStudyDocumentRepository
                    .GetMany(e => e.departmentid == Consts.DepartmentId && e.isnew && !e.isapproved,
                        e => new
                        {
                            e.studentid,
                            e.id
                        })
                    .ToArray();

            return View(new DocumentationStudyDocumentsViewModel
            {
                Persons = studyDocumentInfos.Select(s => MdlBlockDofSPersonsRepository.GetById(s.studentid, e => new PersonModel
                {
                    Id = e.id,
                    LastName = e.lastname,
                    MiddleName = e.middlename,
                    FirstName = e.firstname,
                    StudyDocumentId = s.id
                }))
            });
        }

        [HttpPost]
        public ActionResult StudyDocuments(DocumentationStudyDocumentsModel model)
        {
            if (model.SelectedIdStudyDocuments != null)
            {
                foreach (var id in model.SelectedIdStudyDocuments)
                {
                    var studyDocument = MdlStudyDocumentRepository.GetById(id);

                    studyDocument.isapproved = true;

                    MdlStudyDocumentRepository.Save(studyDocument);
                }

                MdlStudyDocumentRepository.Commit();

                TempData["Message"] = "Заявки о получении справок успешно отправлены";
            }

            return RedirectToAction("StudyDocuments");
        }

        [HttpGet]
        public ActionResult CreateMakeUpAcademicDebtDocuments(long disciplineId)
        {
            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(disciplineId);
            var groups = MdlBlockDofSAgroupsRepository.GetMany(e => e.departmentid == programmItem.departmentid)
                .ToArray();

            var model = new CreateDocumentationMakeUpAcademicDebtDocumentsModel
            {
                ProgrammItemId = programmItem.id,
                DisciplineName = programmItem.name
            };

            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var gradeItem = MdlGradeItemsRepository.FirstOrDefault(e =>
                e.courseid == programmItem.mdlcourse && e.locktime < now && e.itemtype == "manual");
            var gradeses = MdlGradeGradesRepository.GetMany(e => e.itemid == gradeItem.id).ToArray();

            foreach (var group in groups)
            {
                var studentIds = MdlMakeupAcademicdebtRepository
                    .GetMany(e => e.isnew && e.isteacherapproved && !e.isdepartamentapproved, e => e.studentid)
                    .ToArray();

                foreach (var item in gradeses)
                {
                    if (item.finalgrade == null)
                    {
                        var student = MdlBlockDofSPersonsRepository.FirstOrDefault(e => studentIds.Contains(e.id) && e.mdluser == item.userid);

                        model.Students.Add(new StudentModel
                        {
                            Id = student.id,
                            FirstName = student.firstname,
                            LastName = student.lastname,
                            MdlUser = student.mdluser.Value,
                            MiddleName = student.middlename,
                            GroupId = group.id,
                            GroupName = group.name
                        });
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateMakeUpAcademicDebtDocuments(CreateDocumentationMakeUpAcademicDebtDocumentsModel model)
        {
            if (model.StudentIds != null)
            {
                var academicdebts = MdlMakeupAcademicdebtRepository
                    .GetMany(e => model.StudentIds.Contains(e.studentid)
                                  && e.isnew && e.date != null && e.isteacherapproved && !e.isdepartamentapproved)
                    .ToArray();

                foreach (var academicdebt in academicdebts)
                {
                    academicdebt.isdepartamentapproved = true;
                    MdlMakeupAcademicdebtRepository.Save(academicdebt);
                }

                MdlMakeupAcademicdebtRepository.Commit();

                TempData["Message"] = $"Ведомости успешно созданы, вы можете посмотреть их <a href='{this.BuildUrlFromExpression(c => c.MakeUpAcademicDebtDocuments(true, true, model.ProgrammItemId))}'>здесь</a>";
            }

            return RedirectToAction("CreateMakeUpAcademicDebtDocuments", new { disciplineId = model.ProgrammItemId });
        }

        [HttpGet]
        public ActionResult MakeUpAcademicDebtDocuments(bool isNew, bool isDepartmentApproved, long programmItemId)
        {
            var model = new DocumentationMakeUpAcademicDebtDocumentsModel
            {
                ProgrammItemId = programmItemId,
                IsNew = isNew,
                IsDepartmentApproved = isDepartmentApproved,
                DisciplineModels = MdlBlockDofSProgrammitemsRepository.GetMany(e => e.departmentid == Consts.DepartmentId, e => new DisciplineModel
                {
                    Id = e.id,
                    Name = e.name
                }).ToArray()
            };

            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(programmItemId);

            var groups = MdlBlockDofSAgroupsRepository.GetMany(e => e.departmentid == programmItem.departmentid)
                .ToArray();

            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var gradeItem = MdlGradeItemsRepository.FirstOrDefault(e =>
                e.courseid == programmItem.mdlcourse && e.locktime < now && e.itemtype == "manual");
            var gradeses = MdlGradeGradesRepository.GetMany(e => e.itemid == gradeItem.id).ToArray();

            foreach (var group in groups)
            {
                var academicdebtsInfo = MdlMakeupAcademicdebtRepository
                    .GetMany(e => e.isnew == isNew && e.isdepartamentapproved == isDepartmentApproved, e => new
                    {
                        e.studentid,
                        e.date
                    })
                    .ToArray();

                var studentIds = academicdebtsInfo.Select(a => a.studentid);

                foreach (var item in gradeses)
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
                            GroupName = group.name,
                            Date = academicdebtsInfo.First().date.Value,
                            Mark = item.finalgrade,
                            DisciplineModel = new DisciplineModel
                            {
                                Id = programmItem.id,
                                Name = programmItem.name
                            }
                        });
                    }
                }
            }

            return View(model);
        }
    }
}