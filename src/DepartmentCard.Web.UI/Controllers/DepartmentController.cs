using System.Linq;
using System.Web.Mvc;
using DepartmentCard.Web.UI.Models.Department.List;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using Web.Common.App.Extensions;

namespace DepartmentCard.Web.UI.Controllers
{
    public class Consts
    {
        public const long DepartmentId = 6;
    }

    public class DepartmentController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_makeup_academicdebt> MdlMakeupAcademicdebtRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_grade_items> MdlGradeItemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }

        [HttpGet]
        public ActionResult List()
        {
            return View(new DepartmentListModel
            {
                Departments = MdlBlockDofSDepartmentsRepository.GetAll(e => new DepartmentModel
                {
                    Id = e.id,
                    Name = e.name
                }).ToArray()
            });
        }

        [HttpGet]
        public ActionResult Details(long id = Consts.DepartmentId)
        {
            var academicdebts = MdlMakeupAcademicdebtRepository
                .GetAll()
                .GroupBy(e => new { e.gradeitemid, e.date })
                .ToArray();

            foreach (var academicdebt in academicdebts)
            {
                if (academicdebt.All(a => a.isnew && a.isteacherapproved && !a.isdepartamentapproved))
                {
                    var gradeItem = MdlGradeItemsRepository.GetById(academicdebt.Key.gradeitemid);
                    var programmitem = MdlBlockDofSProgrammitemsRepository.FirstOrDefault(e => e.mdlcourse == gradeItem.courseid);
                    var cstream = MdlBlockDofSCstreamsRepository.FirstOrDefault(e => e.programmitemid == programmitem.id);
                    var teacher = MdlBlockDofSPersonsRepository.GetById(cstream.teacherid.Value);

                    TempData["InfoMessage"] +=
                        $"Поступил запрос от преподавателя {teacher.lastname} {teacher.firstname} {teacher.middlename} " +
                        $"на получение ведомостей для пересдачи дисцисцплины {programmitem.name} (дата {academicdebt.Key.date.Value:f})." +
                        $"<a href='{this.BuildUrlFromExpression<DocumentationController>(c => c.CreateMakeUpAcademicDebtDocuments(programmitem.id))}'>Перейдите по ссылке для формирования ведомостей</a>";
                }
            }

            return View();
        }
    }
}