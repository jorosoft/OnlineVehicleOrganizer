using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;

namespace OVO.Data.Contracts
{
    public interface IEfRoleRepository
    {
        UserManager<User> UserManager { get; }

        IQueryable<IdentityRole> All { get; }

        void Add(IdentityRole role);

        void Update(IdentityRole role);
    }
}
