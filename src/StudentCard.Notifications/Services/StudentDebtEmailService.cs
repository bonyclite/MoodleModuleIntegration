using System;
using System.Net.Mail;
using StudentCard.Notifications.Models;

namespace StudentCard.Notifications.Services
{
    public class StudentDebtEmailService : EmailService<StudentDebtEmailModel>
    {
        protected override MailMessage GetMessage(StudentDebtEmailModel model)
        {
            throw new NotImplementedException();
        }

        protected override string GetHtmlTemplate(StudentDebtEmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}