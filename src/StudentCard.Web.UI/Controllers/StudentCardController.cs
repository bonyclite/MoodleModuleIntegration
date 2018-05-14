using System.Linq;
using System.Web.Mvc;
using Common.Extensions;
using Microsoft.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using StudentCard.Web.UI.Models.StudentCard.Front;

namespace StudentCard.Web.UI.Controllers
{
    public class StudentCardController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [AjaxOnly]
        public ActionResult Details(long personId)
        {
            return PartialView("~/Views/StudentCard/Details.cshtml");
        }

        [AjaxOnly]
        public ActionResult Front(long personId)
        {
            var student = MdlBlockDofSPersonsRepository.GetById(personId);

            return PartialView("~/Views/StudentCard/Front.cshtml", new StudentCardFrontModel
            {
                Faculty = new FacultyModel
                {

                }
            });
        }
    }
}