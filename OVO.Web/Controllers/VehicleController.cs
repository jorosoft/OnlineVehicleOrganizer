using System;
using System.Linq;
using System.Web.Mvc;
using OVO.Services.Contracts;
using OVO.Web.ViewModels.Vehicle;


namespace OVO.Web.Controllers
{
    [Authorize(Roles="User")]
    public class VehicleController : Controller
    {
        private readonly IVehiclesService vehiclesService;
        private readonly IManufacturersService manufacturersService;
        private readonly IModelsService modelsService;
        private readonly IUsersService usersService;
        private readonly IVehicleEventsService vehicleEventsService;
        private readonly ICronJobsService cronJobsService;

        public VehicleController(
            IVehiclesService vehiclesService,
            IManufacturersService manufacturersService,
            IModelsService modelsService,
            IUsersService usersService,
            IVehicleEventsService vehicleEventsService,
            ICronJobsService cronJobsService)
        {
            this.vehiclesService = vehiclesService;
            this.manufacturersService = manufacturersService;
            this.modelsService = modelsService;
            this.usersService = usersService;
            this.vehicleEventsService = vehicleEventsService;
            this.cronJobsService = cronJobsService;
        }

        public ActionResult All()
        {
            var currentUser = this.usersService.GetAll()
                .First(x => x.Email == User.Identity.Name);

            var vehicles = this.vehiclesService.GetAll()
                .Where(r => r.Users.All(t => t.Email==currentUser.Email))
                .Select(x => new VehicleViewModel
                {
                    Id = x.Id,
                    ManufacturerName = x.Model.Manufacturer.Name,
                    ModelName = x.Model.Name,
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

            var manufacturers = this.manufacturersService.GetAll()
                .Select(x => new ManufacturerViewModel
                {
                    Id = x.Id,
                    Name = x.Name
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
            var manufacturer = this.manufacturersService.GetAll()
                .First(x => x.Id == vehicle.Model.Manufacturer.Id);

            var model = this.modelsService.GetAll()
                .First(x => x.Id == vehicle.Model.Id);

            model.Manufacturer = manufacturer;

            var currentUser = this.usersService.GetAll()
                .First(x => x.Email== User.Identity.Name);

            var entity = this.vehiclesService.GetDbModel();

            entity.RegNumber = vehicle.RegNumber;
            entity.InsuranceDate = vehicle.InsuranceDate;
            entity.ServiceDate = vehicle.ServiceDate;
            entity.Model = model;
            entity.Users.Add(currentUser);

            this.vehiclesService.Add(entity);

            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult Details(Guid vehicleId)
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(VehicleViewModel vehicle)
        {
            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult AddVehicleEvent(Guid vehicleEventId)
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVehicleEvent(VehicleEventViewModel vehicleEvent)
        {
            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult AddCronJob(Guid cronJobId)
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCronJob(CronJobViewModel cronJob)
        {
            return this.RedirectToAction("All", "Vehicle");
        }
    }
}