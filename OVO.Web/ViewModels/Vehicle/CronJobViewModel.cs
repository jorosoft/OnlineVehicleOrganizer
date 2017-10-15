using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Vehicle
{
    public class CronJobViewModel
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int PeriodInMonths { get; set; }

        public Guid VehicleId { get; set; }
    }
}