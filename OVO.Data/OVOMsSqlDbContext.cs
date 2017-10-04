using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using OVO.Data.Models;

namespace OVO.Data
{
    public class OVOMsSqlDbContext : IdentityDbContext<User>
    {
        public OVOMsSqlDbContext()
            : base("OVOConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<UserDetails> UserDetails { get; set; }

        public static OVOMsSqlDbContext Create()
        {
            return new OVOMsSqlDbContext();
        }
    }
}
