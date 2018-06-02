using System.Net;
using System.Net.Mail;
using System.Text;
using StudentCard.Notifications.Models;

namespace StudentCard.Notifications.Services
{
    public interface IEmailService<TEmailModel> where TEmailModel : EmailModelBase
    {
        void Send(TEmailModel emailModel);
    }

    public abstract class EmailService<TEmailModel> : IEmailService<TEmailModel> where TEmailModel : EmailModelBase
    {
        protected EmailService()
        {
        }

        public virtual void Send(TEmailModel emailModel)
        {
            // TODO: needs to fix.
            using (var client = new SmtpClient("")
            {
                Port = 1488,
                Host = new MailAddress("email", "", Encoding.UTF8).Host,
                Credentials = new NetworkCredential("email", "password"),
                EnableSsl = true,
            })
            {
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;

                client.Send(GetMessage(emailModel));
            }
        }

        protected abstract MailMessage GetMessage(TEmailModel model);

        protected abstract string GetHtmlTemplate(TEmailModel model);
    }
}