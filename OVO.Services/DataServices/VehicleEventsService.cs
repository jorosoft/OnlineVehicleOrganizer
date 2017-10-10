using System.Linq;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class VehicleEventsService : IVehicleEventsService
    {
        private readonly IEfRepository<VehicleEvent> vehicleEventsRepo;
        private readonly ISaveContext context;

        public VehicleEventsService(IEfRepository<VehicleEvent> vehicleEventsRepo, ISaveContext context)
        {
            this.vehicleEventsRepo = vehicleEventsRepo;
            this.context = context;
        }

        public IQueryable<VehicleEvent> GetAll()
        {
            return this.vehicleEventsRepo.All;
        }

        public void Add(VehicleEvent vehicleEvent)
        {
            this.vehicleEventsRepo.Add(vehicleEvent);
            this.context.Commit();
        }

        public void Update(VehicleEvent vehicleEvent)
        {
            this.vehicleEventsRepo.Update(vehicleEvent);
            this.context.Commit();
        }

        public void Delete(VehicleEvent vehicleEvent)
        {
            this.vehicleEventsRepo.Delete(vehicleEvent);
            this.context.Commit();
        }
    }
}
