using System.Linq;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class ManufacturersService : IManufacturersService
    {
        private readonly IEfRepository<Manufacturer> manufacturersRepo;
        private readonly ISaveContext context;

        public ManufacturersService(IEfRepository<Manufacturer> manufacturersRepo, ISaveContext context)
        {
            this.manufacturersRepo = manufacturersRepo;
            this.context = context;
        }

        public IQueryable<Manufacturer> GetAll()
        {
            return this.manufacturersRepo.All;
        }

        public IQueryable<Manufacturer> GetAllAndDeleted()
        {
            return this.manufacturersRepo.AllAndDeleted;
        }

        public void Add(Manufacturer manufacturer)
        {
            this.manufacturersRepo.Add(manufacturer);
            this.context.Commit();
        }

        public void Update(Manufacturer manufacturer)
        {
            this.manufacturersRepo.Update(manufacturer);
            this.context.Commit();
        }

        public void Delete(Manufacturer manufacturer)
        {
            this.manufacturersRepo.Delete(manufacturer);
            this.context.Commit();
        }

        public Manufacturer GetDbModel()
        {
            return new Manufacturer();
        }
    }
}
