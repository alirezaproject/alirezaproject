using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Core.Services.Interfaces;

namespace Core.Services.Impelimentations
{
    public class EmailService : IEmailService
    {
        public  Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            string fromMail = "shekoohianproject2@gmail.com";
            string fromPassword = "@lirezaSHE0917";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body> " + htmlMessage + " </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
            return Task.CompletedTask;
            
        }
    }
}