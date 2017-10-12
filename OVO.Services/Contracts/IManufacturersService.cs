using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IManufacturersService
    {
        IQueryable<Manufacturer> GetAll();

        IQueryable<Manufacturer> GetAllAndDeleted();

        void Add(Manufacturer manufacturer);

        void Update(Manufacturer manufacturer);

        void Delete(Manufacturer manufacturer);
    }
}
