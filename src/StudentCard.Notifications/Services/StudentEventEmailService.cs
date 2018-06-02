using System;
using System.Net.Mail;
using StudentCard.Notifications.Models;

namespace StudentCard.Notifications.Services
{
    public class StudentEventEmailService : EmailService<StudentEventEmailModel>
    {
        protected override MailMessage GetMessage(StudentEventEmailModel model)
        {
            throw new NotImplementedException();
        }

        protected override string GetHtmlTemplate(StudentEventEmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}