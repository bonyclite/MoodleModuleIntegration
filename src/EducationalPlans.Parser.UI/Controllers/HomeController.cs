using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using EducationalPlans.Parser.Api.Extensions;
using EducationalPlans.Parser.Api.Models;
using EducationalPlans.Parser.Api.Services;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;

namespace EducationalPlans.Parser.UI.Controllers
{
    public class HomeController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlEntityRepositoryBase { get; set; }
        public IXmlFileParserService XmlFileParserService { get; set; }
        public IPersonnelSTUService PersonnelStuService { get; set; }

        // GET: Home
        public async Task<ActionResult> Index()
        {
            var persons = MdlEntityRepositoryBase.GetAll().ToArray();
            var faculties = await PersonnelStuService.Get<Faculty>();
            
            return View();
        }
    }
}