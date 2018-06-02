using System.Linq;
using System.Threading.Tasks;
using Moodle3KL.Data.Repositories;
using Moodle3KL.Domain;

namespace StudentCard.Notifications.Services
{
    public interface INotificationService
    {
        Task Notify();
    }

    public class NotificationService : INotificationService
    {
        public IMdlEntityRepositoryBase<mdl_assign_user_flags> MdlAssignUserFlagsRepository { get; set; }

        public async Task Notify()
        {
            var sdf = MdlAssignUserFlagsRepository.GetAll().ToArray();
        }
    }
}