using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OVO.Data.Models;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Web.Areas.Administration.Controllers
{
    public class ModelsController : Controller
    {
        private readonly IModelsService modelsService;

        public ModelsController(IModelsService modelsService)
        {
            this.modelsService = modelsService;
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

            return View(viewModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(enableValidation: true)]
        public ActionResult Add(Guid modelId)
        {
            return View();
        }

        public ActionResult Edit(Guid modelId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(enableValidation: true)]
        public ActionResult Edit(Model model)
        {
            return View();
        }

        public ActionResult Delete(Guid modelId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Model model)
        {
            return View();
        }
    }
}