using System.Linq;
using OVO.Data.Models;

namespace OVO.Services.Contracts
{
    public interface IModelsService
    {
        IQueryable<Model> GetAll();

        void Add(Model model);

        void Update(Model model);

        void Delete(Model model);
    }
}
