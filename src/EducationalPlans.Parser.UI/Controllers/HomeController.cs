using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using PersonnelSTU.Data.Repositories;
using PersonnelSTU.Domain;

namespace EducationalPlans.Parser.UI.Controllers
{
    public class HomeController : Controller
    {
        public IPersonnelSTUEntityRepository<Faculty> EntityRepositoryBase { get; set; }
        public IMdlEntityRepositoryBase<mdl_assign_user_flags> MdlEntityRepositoryBase { get; set; }

        // GET: Home
        public ActionResult Index()
        {
            var df = EntityRepositoryBase.GetAll().ToArray();
            var sdf = MdlEntityRepositoryBase.GetAll().ToArray();
            
            return View();
        }
    }
}