using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IVehiclesService
    {
        IQueryable<Vehicle> GetAll();

        void Add(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Delete(Vehicle vehicle);

        Vehicle GetDbModel();
    }
}
