using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using StudentCard.Notifications.App;
using StudentCard.Notifications.Services;

namespace StudentCard.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new AppStart().Run();
            var notificationService = container.Resolve<INotificationService>();
            notificationService.Notify().Wait();
        }
    }
}