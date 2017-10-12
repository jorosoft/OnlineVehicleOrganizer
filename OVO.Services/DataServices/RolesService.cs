using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Contracts;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class RolesService : IRolesService
    {
        private readonly IEfRoleRepository rolesRepo;
        private readonly ISaveContext context;

        public RolesService(IEfRoleRepository rolesRepo, ISaveContext context)
        {
            this.rolesRepo = rolesRepo;
            this.context = context;
        }

        public IQueryable<IdentityRole> GetAll()
        {
            return this.rolesRepo.All;
        }

        public void Add(IdentityRole role)
        {
            this.rolesRepo.Add(role);
            this.context.Commit();
        }

        public void Update(IdentityRole role)
        {
            this.rolesRepo.Update(role);
            this.context.Commit();
        }
    }
}
