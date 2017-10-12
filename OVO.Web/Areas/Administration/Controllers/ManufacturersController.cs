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

            return View(viewModel);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Guid manufacturerId)
        {
            return View();
        }

        public ActionResult Edit(Guid manufacturerId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            return View();
        }

        public ActionResult Delete(Guid manufacturerId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Manufacturer manufacturer)
        {
            return View();
        }
    }
}