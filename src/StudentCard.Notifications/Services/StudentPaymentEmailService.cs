using System;
using System.Net.Mail;
using StudentCard.Notifications.Models;

namespace StudentCard.Notifications.Services
{
    public class StudentPaymentEmailService : EmailService<StudentPaymentEmailModel>
    {
        protected override MailMessage GetMessage(StudentPaymentEmailModel model)
        {
            throw new NotImplementedException();
        }

        protected override string GetHtmlTemplate(StudentPaymentEmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}