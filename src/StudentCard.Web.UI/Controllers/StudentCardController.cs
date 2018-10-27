using System.Linq;
using System.Web.Mvc;
using Common.Extensions;
using Microsoft.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using StudentCard.Web.UI.Models.StudentCard.Details;
using StudentCard.Web.UI.Models.StudentCard.Front;
using StudentCard.Web.UI.Models.StudentCard.Marks;

namespace StudentCard.Web.UI.Controllers
{
    public class StudentCardController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_departments> MdlBlockDofSDepartmentsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programms> MdlBlockDofSProgrammsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_contracts> MdlBlockDofSContractsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmsbcs> MdlBlockDofSProgrammsbcsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_ages> MdlBlockDofSAgesRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cpassed> MdlBlockDofSCpassedRepository { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [AjaxOnly]
        public ActionResult Details(long personId)
        {
            return PartialView("~/Views/StudentCard/Details.cshtml", new StudentCardDetailsModel
            {
                PersonId = personId
            });
        }

        [ChildActionOnly]
        public ActionResult Front(long personId)
        {
            var student = MdlBlockDofSPersonsRepository.GetById(personId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);
            var contractId = MdlBlockDofSContractsRepository.SingleOrDefault(e => e.studentid == personId, e => e.id);
            var programmId = MdlBlockDofSProgrammsbcsRepository.SingleOrDefault(e => e.contractid == contractId, e => e.programmid.Value);
            var programm = MdlBlockDofSProgrammsRepository.GetById(programmId);

            return PartialView("~/Views/StudentCard/Front.cshtml", new StudentCardFrontModel
            {
                DepartamentName = department.name,
                ProgrammName = programm.name,
                StudentModel = new StudentModel
                {
                    FirstName = student.firstname,
                    MiddleName = student.middlename,
                    LastName = student.lastname,
                    Email = student.email,
                    PhoneHome = student.phonehome,
                    PhoneNumber = student.phonecell
                }               
            });
        }

        [ChildActionOnly]
        public ActionResult Marks(long personId)
        {
            var semesters = MdlBlockDofSAgesRepository.GetAll().ToArray();

            var student = MdlBlockDofSPersonsRepository.GetById(personId);
            var department = MdlBlockDofSDepartmentsRepository.GetById(student.departmentid.Value);

            var model = new StudentCardMarksModel();

            foreach (var semester in semesters)
            {
                var cstreamses = MdlBlockDofSCstreamsRepository
                    .GetMany(e => e.departmentid == department.id && e.ageid == semester.id)
                    .ToArray();

                if (cstreamses.Any())
                {
                    var semesterModel = new SemesterModel
                    {
                        Name = semester.name
                    };

                    foreach (var cstreamse in cstreamses)
                    {
                        if (MdlBlockDofSCpassedRepository.Any(e => e.programmitemid == cstreamse.programmitemid && e.studentid == personId))
                        {
                            var programmItem = MdlBlockDofSProgrammitemsRepository.GetById(cstreamse.programmitemid.Value);

                            semesterModel.Disciplines.Add(new DisciplineModel
                            {
                                Code = cstreamse.name,
                                Hours = cstreamse.hours,
                                Name = programmItem.name
                            });
                        }
                    }

                    if (semesterModel.Disciplines.Any())
                        model.Semesters.Add(semesterModel);
                }
            }

            return PartialView("~/Views/StudentCard/Marks.cshtml", model);
        }
    }
}