using System.Linq;
using System.Web.Mvc;
using OVO.Services.Contracts;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Web.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehiclesService vehiclesService;
        private readonly IManufacturersService manufacturersService;
        private readonly IModelsService modelsService;

        public VehicleController(
            IVehiclesService vehiclesService,
            IManufacturersService manufacturersService,
            IModelsService modelsService)
        {
            this.vehiclesService = vehiclesService;
            this.manufacturersService = manufacturersService;
            this.modelsService = modelsService;
        }

        public ActionResult All()
        {
            var vehicles = this.vehiclesService.GetAll()
                .Select(x => new VehicleViewModel
                {
                    Id = x.Id,
                    Manufacturer = x.Model.Manufacturer.Name,
                    Model = x.Model.Name,
                    RegNumber = x.RegNumber
                })
                .ToList();

            var viewModel = new VehiclesListViewModel
            {
                Vehicles = vehicles
            };

            return this.View(viewModel);
        }

        public ActionResult Add()
        {
            var manufacturers = this.manufacturersService.GetAll()
                .Select(x => new ManufacturerViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();

            var models = this.modelsService.GetAll()
                .Select(x => new ModelViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Manufacturer = new ManufacturerViewModel
                    {
                        Id = x.Manufacturer.Id,
                        Name = x.Manufacturer.Name
                    }
                })
                .ToList();

            var viewModel = new AddVehicleViewModel
            {
                Manufacturers = manufacturers,
                Models = models
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(VehicleViewModel vehicle)
        {


            return this.View();
        }
    }
}