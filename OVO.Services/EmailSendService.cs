using System.Net;
using System.Net.Mail;
using OVO.Services.Contracts;
using System.Threading.Tasks;

namespace OVO.Services
{
    public class EmailSendService : IEmailSendService
    {
        private const string senderName = "OVO Admin";
        private const string senderEmail = "ovoappnotify@gmail.com";

        public async Task SendEmailAsync(string destinationEmail, string message)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var newMessage = new MailMessage();
            newMessage.To.Add(new MailAddress(destinationEmail));
            newMessage.From = new MailAddress(senderEmail);
            newMessage.Subject = "Your email subject";
            newMessage.Body = string.Format(body, senderName, senderEmail, message);
            newMessage.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = senderEmail,
                    Password = "alabala.com"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                await smtp.SendMailAsync(newMessage);
            }
        }
    }
}
