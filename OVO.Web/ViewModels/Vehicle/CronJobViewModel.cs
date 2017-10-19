using System;
using System.ComponentModel.DataAnnotations;
using OVO.Web.Attributes;

namespace OVO.Web.ViewModels.Vehicle
{
    public class CronJobViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [NotDateInPast]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public int PeriodInMonths { get; set; }

        public Guid VehicleId { get; set; }
    }
}