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
                .OrderBy(x => x.Model.Manufacturer.Name)
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

            var viewModel = new VehicleExtendedViewModel
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
            var vehicleEvents = this.vehicleEventsService.GetAll()
                .Where(x => x.Vehicle.Id == vehicleId) 
                .OrderByDescending(x => x.Date)               
                .ToList();

            var cronJobs = this.cronJobsService.GetAll()
                .Where(x => x.Vehicle.Id == vehicleId) 
                .OrderBy(x => x.Name)               
                .ToList();

            var vehicle = this.vehiclesService.GetAll()
                .Select(x => new
                {
                    Id = x.Id,
                    ModelName = x.Model.Name,
                    ManufacturerName = x.Model.Manufacturer.Name,
                    RegNumber = x.RegNumber,
                    InsuranceDate = x.InsuranceDate,
                    ServiceDate = x.ServiceDate
                })                
                .First(x => x.Id == vehicleId);

            var viewModel = new VehicleViewModel
            {
                Id = vehicle.Id,
                ModelName = vehicle.ModelName,
                ManufacturerName = vehicle.ManufacturerName,
                RegNumber = vehicle.RegNumber,
                InsuranceDate = vehicle.InsuranceDate,
                ServiceDate = vehicle.ServiceDate,
                VehicleEvents = vehicleEvents.Select(v => new VehicleEventViewModel
                {
                    Id = v.Id,
                    Name = v.Name,
                    Date = v.Date,
                    Description = v.Description,
                    VehicleId = vehicleId
                }),
                CronJobs = cronJobs.Select(c => new CronJobViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    StartDate = c.StartDate,
                    Description = c.Description,
                    PeriodInMonths = c.PeriodInMonths,
                    VehicleId = vehicleId
                })
                };

            return this.View(viewModel);
        }                

        public ActionResult Edit(Guid vehicleId)
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

            var vehicle = this.vehiclesService.GetAll()
                .Select(x => new VehicleViewModel
                {
                    Id = x.Id,
                    RegNumber = x.RegNumber,
                    ModelName = x.Model.Name,
                    ManufacturerName = x.Model.Manufacturer.Name,
                    InsuranceDate = x.InsuranceDate,
                    ServiceDate = x.ServiceDate
                })
                .First(x => x.Id == vehicleId);

            var viewModel = new VehicleExtendedViewModel
            {
                Manufacturers = manufacturers,
                Models = models,
                Vehicle = vehicle
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VehicleViewModel vehicle)
        {
            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult Delete(Guid vehicleId)
        {
            var vehicle = this.vehiclesService.GetAll()
               .Select(x => new VehicleViewModel
               {
                   Id = x.Id,
                   ModelName = x.Model.Name,
                   ManufacturerName = x.Model.Manufacturer.Name,
                   RegNumber = x.RegNumber
               })
               .First(x => x.Id == vehicleId);

            return this.View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VehicleViewModel vehicle)
        {
            var vehicleToDelete = this.vehiclesService.GetAll()
                .First(x => x.Id == vehicle.Id);

            this.vehiclesService.Delete(vehicleToDelete);

            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult AddVehicleEvent(Guid vehicleId)
        {
            var viewModel = new VehicleEventViewModel
            {
                VehicleId = vehicleId
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVehicleEvent(VehicleEventViewModel vehicleEvent)
        {
            var vehicle = this.vehiclesService.GetAll()
                .First(x => x.Id == vehicleEvent.VehicleId);

            var entity = this.vehicleEventsService.GetDbModel();
            entity.Name = vehicleEvent.Name;
            entity.Date = vehicleEvent.Date;
            entity.Description = vehicleEvent.Description;
            entity.Vehicle = vehicle;

            this.vehicleEventsService.Add(entity);

            return this.RedirectToAction("All", "Vehicle");
        }

        public ActionResult AddCronJob(Guid vehicleId)
        {
            var viewModel = new CronJobViewModel
            {
                VehicleId = vehicleId
            };
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCronJob(CronJobViewModel cronJob)
        {
            var vehicle = this.vehiclesService.GetAll()
                .First(x => x.Id == cronJob.VehicleId);

            var entity = this.cronJobsService.GetDbModel();
            entity.Name = cronJob.Name;
            entity.StartDate = cronJob.StartDate;
            entity.Description = cronJob.Description;
            entity.PeriodInMonths = cronJob.PeriodInMonths;
            entity.Vehicle = vehicle;

            this.cronJobsService.Add(entity);
                        
            return this.RedirectToAction("All", "Vehicle");
        }
    }
}