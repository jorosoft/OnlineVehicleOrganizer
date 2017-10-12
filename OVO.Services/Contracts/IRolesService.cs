using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OVO.Services.Contracts
{
    public interface IRolesService
    {
        IQueryable<IdentityRole> GetAll();

        void Add(IdentityRole role);

        void Update(IdentityRole role);
    }
}
