using System;
using OVO.Data.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace OVO.Data.Models
{
    public class CronJob : DBEntity
    {
        public virtual Vehicle Vehicle { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1, 120)]
        public int PeriodInMonths { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
    }
}
