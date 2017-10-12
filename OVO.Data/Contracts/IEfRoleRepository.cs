using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OVO.Data.Contracts
{
    public interface IEfRoleRepository
    {
        IQueryable<IdentityRole> All { get; }

        void Add(IdentityRole role);

        void Update(IdentityRole role);
    }
}
