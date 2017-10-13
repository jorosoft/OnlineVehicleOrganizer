using System.Linq;
using OVO.Data.Models;
using OVO.Services.Contracts;
using OVO.Data.Contracts;

namespace OVO.Services.DataServices
{
    public class VehiclesService : IVehiclesService
    {
        private readonly IEfRepository<Vehicle> vehiclesRepo;
        private readonly ISaveContext context;

        public VehiclesService(IEfRepository<Vehicle> vehiclesRepo, ISaveContext context)
        {
            this.vehiclesRepo = vehiclesRepo;
            this.context = context;
        }

        public IQueryable<Vehicle> GetAll()
        {
            return this.vehiclesRepo.All;
        }

        public void Add(Vehicle vehicle)
        {
            this.vehiclesRepo.Add(vehicle);
            this.context.Commit();
        }

        public void Update(Vehicle vehicle)
        {
            this.vehiclesRepo.Update(vehicle);
            this.context.Commit();
        }

        public void Delete(Vehicle vehicle)
        {
            this.vehiclesRepo.Delete(vehicle);
            this.context.Commit();
        }

        public Vehicle GetDbModel()
        {
            return new Vehicle();
        }
    }
}
