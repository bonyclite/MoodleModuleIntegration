using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using TeacherCard.Web.UI.App;
using TeacherCard.Web.UI.Models.Teacher.Details;
using Web.Common.App.Extensions;

namespace TeacherCard.Web.UI.Controllers
{
    public class TeacherController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_grade_items> MdlGradeItemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_course> MdlCourseRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_makeup_academicdebt> MdlMakeupAcademicdebtRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }

        [HttpGet]
        public ActionResult Details()
        {
            var teacher = MdlBlockDofSPersonsRepository.FirstOrDefault(e => e.mdluser == Consts.MdlUser);
            var cstreamses = MdlBlockDofSCstreamsRepository.GetMany(e => e.teacherid == teacher.id).ToArray();

            foreach (var cstreamse in cstreamses)
            {
                var programmitem = MdlBlockDofSProgrammitemsRepository.GetById(cstreamse.programmitemid.Value);
                var gradeItemses = MdlGradeItemsRepository.GetMany(e => e.courseid == programmitem.mdlcourse).ToArray();

                var ids = gradeItemses.Select(g => g.id);

                if (MdlMakeupAcademicdebtRepository
                    .Any(e => e.date == null && e.isnew && !e.isteacherapproved && ids.Contains(e.gradeitemid)))
                {
                    TempData["InfoMessage"] +=
                        $"Поступил запрос на пересдачу '{programmitem.name}'. " +
                        $"<a href='{this.BuildUrlFromExpression<StudentController>(c => c.ListWithAcademicDebts(programmitem.id))}'>" +
                        "Перейдите по ссылке, чтобы назначить прием долгов.</a>";
                }

                if (MdlMakeupAcademicdebtRepository.Any(e =>
                    e.date != null && e.isnew && e.isteacherapproved && e.isdepartamentapproved &&
                    ids.Contains(e.gradeitemid)))
                {
                    TempData["InfoMessage"] +=
                        $"Ваша заявка на получение ведомостей по дисциплине '{programmitem.name}' принята. " +
                        $"<a href='{this.BuildUrlFromExpression<DocumentationController>(c=>c.MakeUpAcademicDebtDocuments(programmitem.id))}'>Нажмите сюда</a>, чтобы посмотреть ведомости";
                }
            }

            return View(new TeacherDetailsModel
            {
                MdlUser = Consts.MdlUser
            });
        }
    }
}