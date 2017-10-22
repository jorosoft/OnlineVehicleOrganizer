using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using OVO.Services.Contracts;
using OVO.Services.Enumerations;
using OVO.Services.Models;

namespace OVO.Services
{
    public class EmailSendService : IEmailSendService
    {
        private const string senderName = "OVO Admin";
        private const string senderEmail = "ovoappnotify@gmail.com";
        private const string insuranceSubject = "Vehicle Insurance Expires";
        private const string serviceSubject = "Vehicle Service Check Expires";
        private const string insuranceMailTemplate = "Hello user of OVO App! We notify you than your insurance for vehicle: {0} {1} - {2} expires after 5 days at: {3}.{4}.{5}!";
        private const string serviceMailTemplate = "Hello user of OVO App! We notify you than your service check for vehicle: {0} {1} - {2} expires after 5 days at: {3}.{4}.{5}!";

        public async Task SendEmailAsync(Mail mail)
        {
            var newMessage = new MailMessage();
            newMessage.To.Add(new MailAddress(mail.DestinationEmail));
            newMessage.From = new MailAddress(senderEmail);

            switch (mail.MailType)
            {
                case MailType.InsuranceMail:
                    newMessage.Subject = insuranceSubject;
                    newMessage.Body = string.Format(insuranceMailTemplate, mail.Manufacturer, mail.Model, mail.RegNumber, mail.Day, mail.Month, DateTime.Now.Year);
                    break;
                case MailType.ServiceMail:
                    newMessage.Subject = serviceSubject;
                    newMessage.Body = string.Format(insuranceMailTemplate, mail.Manufacturer, mail.Model, mail.RegNumber, mail.Day, mail.Month, DateTime.Now.Year);
                    break;
                default:
                    break;
            }
                        
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
