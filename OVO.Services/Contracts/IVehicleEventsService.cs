using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IVehicleEventsService
    {
        IQueryable<VehicleEvent> GetAll();

        void Add(VehicleEvent vehicleEvent);

        void Update(VehicleEvent vehicleEvent);

        void Delete(VehicleEvent vehicleEvent);

        VehicleEvent GetDbModel();
    }
}
