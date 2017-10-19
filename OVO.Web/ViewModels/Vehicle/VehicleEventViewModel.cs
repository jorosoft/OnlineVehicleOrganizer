﻿using System;
using System.ComponentModel.DataAnnotations;
using OVO.Web.Attributes;

namespace OVO.Web.ViewModels.Vehicle
{
    public class VehicleEventViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [NotDateInPast]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid VehicleId { get; set; }
    }
}