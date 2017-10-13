using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IRolesService
    {
        UserManager<User> UserManager { get; }

        IQueryable<IdentityRole> GetAll();

        void Add(IdentityRole role);

        void Update(IdentityRole role);
    }
}
