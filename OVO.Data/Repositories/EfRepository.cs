using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using OVO.Data.Contracts;

namespace OVO.Data.Repositories
{
    public class EfRepository<T> : IEfRepository<T>
        where T : class, IDeletable
    {
        private readonly OVOMsSqlDbContext context;

        public EfRepository(OVOMsSqlDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> All
        {
            get
            {
                return this.Context.Set<T>().Where(x => !x.IsDeleted);
            }
        }

        public IQueryable<T> AllAndDeleted
        {
            get
            {
                return this.Context.Set<T>();
            }
        }

        public OVOMsSqlDbContext Context
        {
            get
            {
                return context;
            }
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.Context.Set<T>().Add(entity);
            }
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;

            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.Context.Set<T>().Attach(entity);
            }

            entry.State = EntityState.Modified;
        }
    }
}
