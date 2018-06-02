using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EducationalPlans.Parser.Api.Models;
using EducationalPlans.Parser.Api.Services;
using Moodle3KL.Data.Infrastructure;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;

namespace EducationalPlans.Parser.UI.Controllers
{
    public class HomeController : Controller
    {
        public const int FacultyId = 1073;

        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programms> MdlBlockDofSProgrammsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IPersonnelSTUService PersonnelStuService { get; set; }
        public IMoodle3KLUnitOfWork Moodle3KlUnitOfWork { get; set; }

        // GET: Home
        public async Task<ActionResult> Index()
        {
            //await LoadFaculties();
            await LoadPrograms(FacultyId);
            await LoadPersons(FacultyId);

            return View();
        }

        public async Task LoadFaculties()
        {
            var faculties = await PersonnelStuService.Get<Faculty>();

            foreach (var faculty in faculties)
            {
                MdlBlockDofSDepartmentsRepository.Save(new mdl_block_dof_s_departments
                {
                    name = faculty.Name,
                    code = faculty.Id.ToString(),
                    status = "active",
                    managerid = 0,
                    zone = "99" //часовая зона
                });
            }

            Moodle3KlUnitOfWork.Commit();
        }

        public async Task LoadPrograms(int facultyId)
        {
            var programs = (await PersonnelStuService.Get<Specialty>()).Where(s => s.Faculty == facultyId);
            var moodle3KlFacultyId = MdlBlockDofSDepartmentsRepository.SingleOrDefault(d => d.code == "9", d => d.id);

            foreach (var specialty in programs)
            {
                MdlBlockDofSProgrammsRepository.Save(new mdl_block_dof_s_programms
                {
                    name = specialty.Name,
                    departmentid = moodle3KlFacultyId,
                    agenums = 1,
                    edulevel = 7, // высшее образование
                    code = specialty.SpecNumber,
                    status = "available"
                });
            }

            Moodle3KlUnitOfWork.Commit();
        }

        public async Task LoadPersons(int facultyId)
        {
            var persons = await PersonnelStuService.Get<Person>();

            foreach (var person in persons)
            {
                var names = person.Name.Split(' ');
                var firstName = names[1];
                var lastName = names.First();
                var middleName = names.Last();

                MdlBlockDofSPersonsRepository.Save(new mdl_block_dof_s_persons
                {
                    firstname = firstName,
                    lastname = lastName,
                    middlename = middleName,
                    sortname = person.Name,
                    email = "example@gmail.com",
                    gender = "unknown",
                    status = "normal"
                });
            }
        }
    }
}