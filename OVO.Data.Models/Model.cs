using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OVO.Data.Models.Abstractions;

namespace OVO.Data.Models
{
    public class Model : DBEntity
    {
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Name { get; set; }

        public Guid ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
