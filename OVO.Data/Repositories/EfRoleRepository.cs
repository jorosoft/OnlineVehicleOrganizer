using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Contracts;

namespace OVO.Data.Repositories
{
    public class EfRoleRepository : IEfRoleRepository
    {
        private readonly OVOMsSqlDbContext context;

        public EfRoleRepository(OVOMsSqlDbContext context)
        {
            this.context = context;
        }

        public IQueryable<IdentityRole> All
        {
            get
            {
                return this.Context.Set<IdentityRole>();
            }
        }

        public OVOMsSqlDbContext Context
        {
            get
            {
                return context;
            }
        }

        public void Add(IdentityRole role)
        {
            DbEntityEntry entry = this.Context.Entry(role);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.Context.Set<IdentityRole>().Add(role);
            }
        }
        
        public void Update(IdentityRole role)
        {
            DbEntityEntry entry = this.Context.Entry(role);
            if (entry.State == EntityState.Detached)
            {
                this.Context.Set<IdentityRole>().Attach(role);
            }

            entry.State = EntityState.Modified;
        }
    }
}
