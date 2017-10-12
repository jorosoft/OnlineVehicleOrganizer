using System;
using OVO.Data.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace OVO.Data.Models
{
    public class VehicleEvent : DBEntity
    {
        public Guid VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
