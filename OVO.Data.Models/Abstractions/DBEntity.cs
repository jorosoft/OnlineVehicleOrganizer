using System;
using System.ComponentModel.DataAnnotations.Schema;
using OVO.Data.Contracts;

namespace OVO.Data.Models.Abstractions
{
    public abstract class DBEntity : IDeletable
    {
        public DBEntity()
        {
            this.Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
