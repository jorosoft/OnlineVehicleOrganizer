﻿using System;
using System.Linq;
using System.Threading.Tasks;
using OVO.Services.Contracts;
using OVO.Services.Enumerations;
using OVO.Services.Models;

namespace OVO.Services
{
    public class DailyMaintenanceService : IDailyMaintenanceService
    {
        private readonly IEmailSendService emailService;
        private readonly IVehiclesService vehiclesService;

        public DailyMaintenanceService(IEmailSendService emailService, IVehiclesService vehiclesService)
        {
            this.emailService = emailService;
            this.vehiclesService = vehiclesService;
        }

        public async Task Execute()
        {
            var targetDate = DateTime.Now.AddDays(7);

            var toNotifyForInsurance = this.vehiclesService.GetAll()
                .Select(x => new Mail
                {
                    Day = x.InsuranceDate.Day,
                    Month = x.InsuranceDate.Month,
                    RegNumber = x.RegNumber,
                    Manufacturer = x.Model.Manufacturer.Name,
                    Model = x.Model.Name,
                    DestinationEmail = x.Users.FirstOrDefault().Email,
                    MailType = MailType.InsuranceMail
                })
                .Where(x => (x.Day == targetDate.Day && x.Month == targetDate.Month))
                .ToList();            

            var toNotifyForService = this.vehiclesService.GetAll()
                .Select(x => new Mail
                {
                    Day = x.ServiceDate.Day,
                    Month = x.ServiceDate.Month,
                    RegNumber = x.RegNumber,
                    Manufacturer = x.Model.Manufacturer.Name,
                    Model = x.Model.Name,
                    DestinationEmail = x.Users.FirstOrDefault().Email,
                    MailType = MailType.ServiceMail
                })
                .Where(x => (x.Day == targetDate.Day && x.Month == targetDate.Month))
                .ToList();
            
            foreach (var mail in toNotifyForInsurance)
            {
                await this.emailService.SendEmailAsync(mail);
            }

            foreach (var mail in toNotifyForService)
            {
                await this.emailService.SendEmailAsync(mail);
            }
        }
    }
}
