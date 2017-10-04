using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;
using OVO.Data.Contracts;

namespace OVO.Data
{
    public class OVOMsSqlDbContext : IdentityDbContext<User>
    {
        public OVOMsSqlDbContext()
            : base("OVOConnection", throwIfV1Schema: false)
        {
        }

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
