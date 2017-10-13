using System.Linq;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class ModelsService : IModelsService
    {
        private readonly IEfRepository<Model> modelsRepo;
        private readonly ISaveContext context;

        public ModelsService(IEfRepository<Model> modelsRepo, ISaveContext context)
        {
            this.modelsRepo = modelsRepo;
            this.context = context;
        }

        public IQueryable<Model> GetAll()
        {
            return this.modelsRepo.All;
        }

        public IQueryable<Model> GetAllAndDeleted()
        {
            return this.modelsRepo.AllAndDeleted;
        }

        public void Add(Model model)
        {
            this.modelsRepo.Add(model);
            this.context.Commit();
        }

        public void Update(Model model)
        {
            this.modelsRepo.Update(model);
            this.context.Commit();
        }

        public void Delete(Model model)
        {
            this.modelsRepo.Delete(model);
            this.context.Commit();
        }

        public Model GetDbModel()
        {
            return new Model();
        }
    }
}
