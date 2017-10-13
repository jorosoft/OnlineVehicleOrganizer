using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OVO.Data.Models;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.ViewModels;
using AutoMapper.QueryableExtensions;

namespace OVO.Web.Areas.Administration.Controllers
{
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
        public ActionResult Add(Manufacturer manufacturer)
        {
            this.manufacturersService.Add(manufacturer);

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
        public ActionResult Edit(Manufacturer manufacturer)
        {
            this.manufacturersService.Update(manufacturer);

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
        public ActionResult Delete(Manufacturer manufacturer)
        {
            this.manufacturersService.Delete(manufacturer);

            return this.RedirectToAction("All", "Manufacturers");
        }
    }
}