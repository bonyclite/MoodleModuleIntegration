using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using StudentCard.Web.UI.Models.Persons.List;

namespace StudentCard.Web.UI.Controllers
{
    public class PersonsController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }

        [HttpPost]
        public ActionResult List(PersonsListModel model)
        {
            var persons = MdlBlockDofSPersonsRepository
                .GetMany(p => (model.FirstName != null && p.firstname.ToLower().Contains(model.FirstName.ToLower()))
                              || (model.MiddleName != null && p.middlename.ToLower().Contains(model.MiddleName.ToLower()))
                              || (model.LastName != null && p.lastname.ToLower().Contains(model.LastName.ToLower())))
                .ToArray();

            return Json(new { Persons = persons });
        }
    }
}