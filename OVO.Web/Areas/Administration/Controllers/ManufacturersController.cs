using System;
using System.Linq;
using System.Web.Mvc;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManufacturersController : Controller
    {
        private readonly IManufacturersService manufacturersService;

        public ManufacturersController(IManufacturersService manufacturersService)
        {
            this.manufacturersService = manufacturersService;
        }

        public ActionResult All()
        {
            var manufacturers = this.manufacturersService
                .GetAllAndDeleted()
                .OrderBy(x => x.Name)
                .Select(x => new ManufacturerViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted
                })
                .ToList();

            var viewModel = new ManufacturersListViewModel
            {
                Manufacturers = manufacturers
            };

            return this.View(viewModel);
        }

        public ActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ManufacturerViewModel manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return this.View(manufacturer);
            }

            var mf = this.manufacturersService.GetDbModel();

            mf.Name = manufacturer.Name;

            this.manufacturersService.Add(mf);

            return this.RedirectToAction("All", "Manufacturers");
        }

        public ActionResult Edit(Guid manufacturerId)
        {
            var manufacturer = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturerId);

            var viewModel = new ManufacturerViewModel
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                IsDeleted = manufacturer.IsDeleted
            }; 

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ManufacturerViewModel manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return this.View(manufacturer);
            }

            var mf = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturer.Id);

            mf.Name = manufacturer.Name;

            this.manufacturersService.Update(mf);

            return this.RedirectToAction("All", "Manufacturers");
        }

        public ActionResult Delete(Guid manufacturerId)
        {
            var manufacturer = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturerId);

            var viewModel = new ManufacturerViewModel
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                IsDeleted = manufacturer.IsDeleted
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ManufacturerViewModel manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return this.View(manufacturer);
            }

            var mf = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturer.Id);

            this.manufacturersService.Delete(mf);

            return this.RedirectToAction("All", "Manufacturers");
        }

        public ActionResult Undelete(Guid manufacturerId)
        {
            var manufacturer = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturerId);

            var viewModel = new ManufacturerViewModel
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                IsDeleted = manufacturer.IsDeleted
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Undelete(ManufacturerViewModel manufacturer)
        {
            if (!ModelState.IsValid)
            {
                return this.View(manufacturer);
            }

            var mf = this.manufacturersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Id == manufacturer.Id);

            mf.IsDeleted = false;

            this.manufacturersService.Update(mf);

            return this.RedirectToAction("All", "Manufacturers");
        }
    }
}