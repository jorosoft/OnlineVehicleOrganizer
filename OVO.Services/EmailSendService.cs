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
        private const string SenderName = "OVO Admin";
        private const string SenderEmail = "ovoappnotify@gmail.com";
        private const string InsuranceSubject = "Vehicle Insurance Expires";
        private const string ServiceSubject = "Vehicle Service Check Expires";
        private const string InsuranceMailTemplate = "Hello user of OVO App! We notify you than your insurance for vehicle: {0} {1} - {2} expires after 5 days at: {3}.{4}.{5}!";
        private const string ServiceMailTemplate = "Hello user of OVO App! We notify you than your service check for vehicle: {0} {1} - {2} expires after 5 days at: {3}.{4}.{5}!";
        private const string MaintanceSubject = "Daily Maintenance Completed";
        private const string MaintanceMailTemplate = "{0}.{1} - Daily Maintenence Completed! {2} vehicles notified!";

        public async Task SendEmailAsync(Mail mail)
        {
            var newMessage = new MailMessage();
            newMessage.To.Add(new MailAddress(mail.DestinationEmail));
            newMessage.From = new MailAddress(SenderEmail);

            switch (mail.MailType)
            {
                case MailType.InsuranceMail:
                    newMessage.Subject = InsuranceSubject;
                    newMessage.Body = string.Format(InsuranceMailTemplate, mail.Manufacturer, mail.Model, mail.RegNumber, mail.Day, mail.Month, DateTime.Now.Year);
                    break;
                case MailType.ServiceMail:
                    newMessage.Subject = ServiceSubject;
                    newMessage.Body = string.Format(InsuranceMailTemplate, mail.Manufacturer, mail.Model, mail.RegNumber, mail.Day, mail.Month, DateTime.Now.Year);
                    break;
                case MailType.SystemMail:
                    newMessage.Subject = MaintanceSubject;
                    newMessage.Body = string.Format(MaintanceMailTemplate, mail.Day, mail.Month, mail.NotifiedVehiclesCount);
                    break;
                default:
                    break;
            }
                        
            newMessage.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = SenderEmail,
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
