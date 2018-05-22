using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PersonnelSTU.Core.Data.Repositories;
using PersonnelSTU.Core.Domain;

namespace PersonnelSTU.Core.Data.Web.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public IPersonnelSTUCoreEntityRepository<Faculty> PersonnelStuCoreFacultyRepository { get; }

        public ValuesController(IPersonnelSTUCoreEntityRepository<Faculty> personnelStuCoreFacultyRepository)
        {
            PersonnelStuCoreFacultyRepository = personnelStuCoreFacultyRepository;
        }

        [HttpGet]
        public IEnumerable<Faculty> GetFaculties()
        {
            return PersonnelStuCoreFacultyRepository.GetAll().ToArray();
        }
    }
}
