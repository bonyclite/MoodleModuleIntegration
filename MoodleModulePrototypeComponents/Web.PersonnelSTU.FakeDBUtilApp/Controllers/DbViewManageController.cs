using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonnelSTU.Data.Infrastructure;
using PersonnelSTU.FakeDBUtilAPI.Providers;
using Web.Common.App.Extensions;
using Web.PersonnelSTU.FakeDBUtilApp.Views.DbViewManage;

namespace Web.PersonnelSTU.FakeDBUtilApp.Controllers
{
    public class DbViewManageController : Controller
    {
        public IDbProvider DbProvider { get; set; }
        public IFakeDbProvider FakeDbProvider { get; set; }
        public PersonnelStuDbFactory DbFactory { get; set; }

        [HttpGet]
        public ActionResult List()
        {
            return View(new ListModel
            {
                Views = FakeDbProvider.GetViews().Select(v => new SelectListItem
                {
                    Text = v,
                    Value = v
                }).ToList()
            });
        }

        [HttpPost]
        public ActionResult List(ListModel model)
        {
            return this.Ok();
        }
    }
}