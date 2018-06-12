using System;
using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using TeacherCard.Web.UI.Models.Student.ListWithAcademicDebts;

namespace TeacherCard.Web.UI.Controllers
{
    public class StudentController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_items> MdlGradeItemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_grades> MdlGradeGradesRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_agroups> MdlBlockDofSAgroupsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmsbcs> MdlBlockDofSProgrammsbcsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_contracts> MdlBlockDofSContractsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_makeup_academicdebt> MdlMakeupAcademicdebtRepository { get; set; }

        [HttpGet]
        public ActionResult ListWithAcademicDebts(long disciplineId)
        {
            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(disciplineId);
            var groups = MdlBlockDofSAgroupsRepository.GetMany(e => e.departmentid == programmItem.departmentid)
                .ToArray();

            var model = new StudentListWithAcademicDebtsModel
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
                var programmsbcses = MdlBlockDofSProgrammsbcsRepository
                    .GetMany(e => e.agroupid == group.id && e.status == "active", e => e.contractid).ToArray();

                var studentIds = MdlBlockDofSContractsRepository
                    .GetMany(e => programmsbcses.Contains(e.id), e => e.studentid)
                    .ToArray();

                foreach (var item in gradeses)
                {
                    if (item.finalgrade == null)
                    {
                        var student = MdlBlockDofSPersonsRepository.FirstOrDefault(e => studentIds.Contains(e.id) && e.mdluser == item.userid);

                        model.Students.Add(new StundetModel
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
        public ActionResult ListWithAcademicDebts(StudentListWithAcademicDebtsModel model)
        {
            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(model.ProgrammItemId);
            var gradeItem = MdlGradeItemsRepository.FirstOrDefault(e => e.courseid == programmItem.mdlcourse && e.itemtype == "manual");

            if (model.StudentIds != null)
            {
                foreach (var studentId in model.StudentIds)
                {
                    var academicdebt = MdlMakeupAcademicdebtRepository.FirstOrDefault(e =>
                        e.studentid == studentId && e.isnew && e.date == null);

                    if (academicdebt == null)
                    {
                        academicdebt = new mdl_makeup_academicdebt
                        {
                            date = model.MakeUpAcademicDebtsDate,
                            gradeitemid = gradeItem.id,
                            isteacherapproved = true,
                            isnew = true,
                            isdepartamentapproved = false,
                            studentid = studentId
                        };
                    }
                    else
                    {
                        academicdebt.date = model.MakeUpAcademicDebtsDate;
                        academicdebt.isteacherapproved = true;
                    }

                    MdlMakeupAcademicdebtRepository.Save(academicdebt);
                }

                MdlMakeupAcademicdebtRepository.Commit();
            }

            TempData["Message"] =
                $"Заявка на пересдачу дисциплины {programmItem.name} успешно отправлена на обработку в деканат";

            return RedirectToAction("ListWithAcademicDebts", "Student", new { disciplineId = model.ProgrammItemId });
        }
    }
}