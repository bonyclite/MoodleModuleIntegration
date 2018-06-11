using System.Linq;
using System.Web.Mvc;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;
using TeacherCard.Web.UI.Models.Discipline.List;

namespace TeacherCard.Web.UI.Controllers
{
    public class DisciplineController : Controller
    {
        public IMdlEntityRepositoryBase<mdl_block_dof_s_persons> MdlBlockDofSPersonsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_cstreams> MdlBlockDofSCstreamsRepository { get; set; }
        public IMdlEntityRepositoryBase<mdl_block_dof_s_programmitems> MdlBlockDofSProgrammitemsRepository { get; set; }

        [ChildActionOnly]
        public ActionResult List(long teacherId)
        {
            var teacher = MdlBlockDofSPersonsRepository.FirstOrDefault(e => e.mdluser == teacherId);

            var cstreamses = MdlBlockDofSCstreamsRepository.GetMany(e => e.teacherid == teacher.id).ToArray();

            var ids = cstreamses.Select(c => c.programmitemid);

            var disciplinesFrom3KL = MdlBlockDofSProgrammitemsRepository
                .GetMany(e => ids.Contains(e.id))
                .ToArray();

            return PartialView(new DisciplineListModel
            {
                Disciplines = disciplinesFrom3KL.Select(e => new DisciplineModel
                {
                    MdlCourse = e.mdlcourse.Value,
                    ProgrammItemId = e.id,
                    Name = e.name
                })
            });
        }
    }
}