using System.Linq;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class UsersService : IUsersService
    {
        private readonly IEfRepository<User> usersRepo;
        private readonly ISaveContext context;

        public UsersService(IEfRepository<User> usersRepo, ISaveContext context)
        {
            this.usersRepo = usersRepo;
            this.context = context;
        }

        public IQueryable<User> GetAll()
        {
            return this.usersRepo.All;
        }

        public IQueryable<User> GetAllAndDeleted()
        {
            return this.usersRepo.AllAndDeleted;
        }

        public void Add(User user)
        {
            this.usersRepo.Add(user);
            this.context.Commit();
        }

        public void Update(User user)
        {
            this.usersRepo.Update(user);
            this.context.Commit();
        }
        
        public void Delete(User user)
        {
            this.usersRepo.Delete(user);
            this.context.Commit();
        }        
    }
}
