using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;
using OVO.Data.Models.Contracts;

namespace OVO.Data
{
    public class OVOMsSqlDbContext : IdentityDbContext<User>
    {
        public OVOMsSqlDbContext()
            : base("OVOConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Vehicle> Vehicles { get; set; }

        public IDbSet<Manufacturer> Manufacturers { get; set; }

        public IDbSet<Model> Models { get; set; }

        public IDbSet<VehicleEvent> VehicleEvents { get; set; }

        public IDbSet<CronJob> CronJobs { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditable && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditable)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        public static OVOMsSqlDbContext Create()
        {
            return new OVOMsSqlDbContext();
        }
    }
}
