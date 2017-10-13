using System;
using System.Linq;
using System.Web.Mvc;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Web.Areas.Administration.Controllers
{
    public class ModelsController : Controller
    {
        private readonly IModelsService modelsService;
        private readonly IManufacturersService manufacturersService;

        public ModelsController(IModelsService modelsService, IManufacturersService manufacturersService)
        {
            this.modelsService = modelsService;
            this.manufacturersService = manufacturersService;
        }

        public ActionResult All()
        {
            var models = this.modelsService
                .GetAllAndDeleted()
                .OrderBy(x => x.Manufacturer.Name)
                .ThenBy(x => x.Name)
                .Select(x => new ModelViewModel
                {
                    Id = x.Id,
                    ManufacturerName = x.Manufacturer.Name,
                    ModelName = x.Name,
                    IsDeleted = x.IsDeleted
                })
                .ToList();

            var viewModel = new ModelsListViewModel
            {
                Models = models
            };

            return this.View(viewModel);
        }

        public ActionResult Add()
        {
            var manufacturers = this.manufacturersService.GetAllAndDeleted()
                .Select(x => new ManufacturerViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,                    
                })
                .ToList();

            var viewModel = new ModelViewModel
            {
                Manufacturers = manufacturers
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ModelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // TODO

            }

            var mf = this.manufacturersService.GetAllAndDeleted()
                .SingleOrDefault(x => x.Name == model.ManufacturerName);

            var mod = this.modelsService.GetDbModel();
            mod.Name = model.ModelName;
            mod.Manufacturer = mf;

            this.modelsService.Add(mod);

            return this.RedirectToAction("All", "Models");
        }

        public ActionResult Edit(Guid modelId)
        {
            var model = this.modelsService
                .GetAllAndDeleted()
                .Select(x => new ModelViewModel
                {
                    Id = x.Id,
                    ManufacturerName = x.Manufacturer.Name,
                    ModelName = x.Name,
                    IsDeleted = x.IsDeleted
                })
                .SingleOrDefault(x => x.Id == modelId);
            
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // TODO
            }

            var mod = this.modelsService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == model.Id);

            mod.Name = model.ModelName;

            this.modelsService.Update(mod);

            return this.RedirectToAction("All", "Models");
        }

        public ActionResult Delete(Guid modelId)
        {
            var model = this.modelsService
                .GetAllAndDeleted()
                .Select(x => new ModelViewModel
                {
                    Id = x.Id,
                    ManufacturerName = x.Manufacturer.Name,
                    ModelName = x.Name,
                    IsDeleted = x.IsDeleted
                })
                .SingleOrDefault(x => x.Id == modelId);         

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ModelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // TODO
            }

            var mod = this.modelsService
                 .GetAllAndDeleted()
                 .SingleOrDefault(x => x.Id == model.Id);

            this.modelsService.Delete(mod);

            return this.RedirectToAction("All", "Models");
        }

        public ActionResult Undelete(Guid modelId)
        {
            var model = this.modelsService
                .GetAllAndDeleted()
                .Select(x => new ModelViewModel
                {
                    Id = x.Id,
                    ManufacturerName = x.Manufacturer.Name,
                    ModelName = x.Name,
                    IsDeleted = x.IsDeleted
                })
                .SingleOrDefault(x => x.Id == modelId);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Undelete(ModelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // TODO
            }

            var mod = this.modelsService
                 .GetAllAndDeleted()
                 .SingleOrDefault(x => x.Id == model.Id);

            mod.IsDeleted = false;

            this.modelsService.Update(mod);

            return this.RedirectToAction("All", "Models");
        }
    }
}