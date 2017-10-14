﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.ViewModels.Vehicle
{
    public class VehicleViewModel
    {
        public Guid Id { get; set; }
        
        public ModelViewModel Model { get; set; }

        public string ModelName { get; set; }

        public string ManufacturerName { get; set; }

        public string RegNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InsuranceDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ServiceDate { get; set; }
    }
}