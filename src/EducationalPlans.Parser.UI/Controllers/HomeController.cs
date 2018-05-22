using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;

namespace EducationalPlans.Parser.UI.Controllers
{
    public class HomeController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_assign_user_flags> MdlEntityRepositoryBase { get; set; }

        private readonly HttpClient _httpClient;

        public HomeController(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }

        // GET: Home
        public async Task<ActionResult> Index()
        {
            //var sdf = MdlEntityRepositoryBase.GetAll().ToArray();
            _httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("API-HOST"));

            var response = await _httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "api/PersonnelSTU/GetFaculties"));
            
            return View();
        }
    }
}