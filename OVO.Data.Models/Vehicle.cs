using System;
using System.Collections.Generic;
using OVO.Data.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OVO.Data.Models
{
    public class Vehicle : DBEntity
    {
        private ICollection<User> users;
        private ICollection<VehicleEvent> vehicleEvents;
        private ICollection<CronJob> cronJobs;

        public Vehicle()
        {
            this.users = new HashSet<User>();
            this.vehicleEvents = new HashSet<VehicleEvent>();
            this.cronJobs = new HashSet<CronJob>();
        }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(4)]
        [MaxLength(15)]
        public string RegNumber { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime InsuranceDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ServiceDate { get; set; }

        public virtual ICollection<User> Users
        {
            get
            {
                return this.users;
            }
            set
            {
                this.users = value;
            }
        }

        public virtual ICollection<VehicleEvent> VehicleEvents
        {
            get
            {
                return this.vehicleEvents;
            }
            set
            {
                this.vehicleEvents = value;
            }
        }

        public virtual ICollection<CronJob> CronJobs
        {
            get
            {
                return this.cronJobs;
            }
            set
            {
                this.cronJobs = value;
            }
        }
    }
}
