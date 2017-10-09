using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OVO.Data.Models.Abstractions;

namespace OVO.Data.Models
{
    public class Model :DBEntity
    {
        [Required]
        [Index(IsUnique = true)]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
