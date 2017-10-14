using System.Net;
using System.Net.Mail;
using OVO.Services.Contracts;

namespace OVO.Services
{
    public class EmailService : IEmailService
    {
        private const string SenderEmail = "admin@ovo.com";
        private const string SenderName = "OVO Administrator";
        private const string EmailSubject = "Your email subject";
        private const string EmailTemplate = @"<p>Email From: {0} ({1})</p>
                                                <p>Message:</p>
                                                <p>{2}</p>";

        public async void SendAsync(string toEmail, string emailBody)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(toEmail));
            message.From = new MailAddress(SenderEmail);
            message.Subject = EmailSubject;
            message.Body = string.Format(EmailTemplate, SenderName, SenderEmail, emailBody);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "user@outlook.com",
                    Password = "password"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }
    }
}
