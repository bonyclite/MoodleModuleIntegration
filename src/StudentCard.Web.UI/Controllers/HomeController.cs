using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;

namespace StudentCard.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_ages> Mdl_block_dof_s_agesRepository { get; set; }

        public ActionResult Index()
        {
            var sdf = Mdl_block_dof_s_agesRepository.GetAll().ToArray();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}