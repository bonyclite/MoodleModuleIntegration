using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonnelSTU.Core.Data.Repositories;
using PersonnelSTU.Core.Domain;

namespace PersonnelSTU.Core.Data.Web.API.Controllers
{
    [Produces("application/json")]
    [AllowAnonymous]
    [Route("api/PersonnelSTU")]
    public class PersonnelSTUController : Controller
    {
        public IPersonnelSTUCoreEntityRepository<Faculty> PersonnelStuCoreFacultyRepository { get; }
        public IPersonnelSTUCoreEntityRepository<Group> PersonnelStuCoreGroupRepository { get; }
        public IPersonnelSTUCoreEntityRepository<Person> PersonnelStuCorePersonRepository { get; }
        public IPersonnelSTUCoreEntityRepository<Specialty> PersonnelStuCoreSpecialtyRepository { get; }
        public IPersonnelSTUCoreEntityRepository<StudentState> PersonnelStuCoreStudentStateRepository { get; }
        public IPersonnelSTUCoreEntityRepository<StuState> PersonnelStuCoreStuStateRepository { get; }
        public IPersonnelSTUCoreEntityRepository<Teacher> PersonnelStuCoreTeacherRepository { get; }

        public PersonnelSTUController(
            IPersonnelSTUCoreEntityRepository<Faculty> personnelStuCoreFacultyRepository,
            IPersonnelSTUCoreEntityRepository<Group> personnelStuCoreGroupRepository,
            IPersonnelSTUCoreEntityRepository<Person> personnelStuCorePersonRepository,
            IPersonnelSTUCoreEntityRepository<Specialty> personnelStuCoreSpecialtyRepository,
            IPersonnelSTUCoreEntityRepository<StudentState> personnelStuCoreStudentStateRepository,
            IPersonnelSTUCoreEntityRepository<StuState> personnelStuCoreStuStateRepository,
            IPersonnelSTUCoreEntityRepository<Teacher> personnelStuCoreTeacherRepository)
        {
            PersonnelStuCoreFacultyRepository = personnelStuCoreFacultyRepository;
            PersonnelStuCoreGroupRepository = personnelStuCoreGroupRepository;
            PersonnelStuCorePersonRepository = personnelStuCorePersonRepository;
            PersonnelStuCoreSpecialtyRepository = personnelStuCoreSpecialtyRepository;
            PersonnelStuCoreStudentStateRepository = personnelStuCoreStudentStateRepository;
            PersonnelStuCoreStuStateRepository = personnelStuCoreStuStateRepository;
            PersonnelStuCoreTeacherRepository = personnelStuCoreTeacherRepository;
        }

        [HttpGet]
        [Route("GetFaculties")]
        public IEnumerable<Faculty> GetFaculties()
        {
            return PersonnelStuCoreFacultyRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetGroups")]
        public IEnumerable<Group> GetGroups()
        {
            return PersonnelStuCoreGroupRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetPersons")]
        public IEnumerable<Person> GetPersons()
        {
            return PersonnelStuCorePersonRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetSpecialties")]
        public IEnumerable<Specialty> GetSpecialties()
        {
            return PersonnelStuCoreSpecialtyRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetStudentStates")]
        public IEnumerable<StudentState> GetStudentStates()
        {
            return PersonnelStuCoreStudentStateRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetStuStates")]
        public IEnumerable<StuState> GetStuStates()
        {
            return PersonnelStuCoreStuStateRepository.GetAll().ToArray();
        }

        [HttpGet]
        [Route("GetTeachers")]
        public IEnumerable<Teacher> GetTeachers()
        {
            return PersonnelStuCoreTeacherRepository.GetAll().ToArray();
        }
    }
}