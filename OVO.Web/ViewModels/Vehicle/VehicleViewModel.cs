using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Vehicle
{
    public class VehicleViewModel
    {
        public Guid Id { get; set; }

        public Guid ManufacturerId { get; set; }

        public Guid ModelId { get; set; }

        public string ManufacturerName { get; set; }

        public string ModelName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string RegNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InsuranceDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ServiceDate { get; set; }

        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }

        public IEnumerable<ModelViewModel> Models { get; set; }

        public IEnumerable<VehicleEventViewModel> VehicleEvents { get; set; }

        public IEnumerable<CronJobViewModel> CronJobs { get; set; }
    }
}