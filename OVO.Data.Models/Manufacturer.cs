using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OVO.Data.Models.Abstractions;

namespace OVO.Data.Models
{
    public class Manufacturer : DBEntity
    {
        private ICollection<Model> models;

        public Manufacturer()
        {
            this.models = new HashSet<Model>();
        }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(2)]
        [MaxLength(15)]
        public string Name { get; set; }

        public virtual ICollection<Model> Models
        {
            get
            {
                return this.models;
            }
            set
            {
                this.models = value;
            }
        }
    }
}
