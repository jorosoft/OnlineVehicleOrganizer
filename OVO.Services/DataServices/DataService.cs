using System;
using OVO.Services.Contracts;

namespace OVO.Services.DataServices
{
    public class DataService : IDataService
    {
        public ICronJobsService CronJobsService { get; }        

        public IManufacturersService ManufacturersService { get; }

        public IModelsService ModelsService { get; }

        public IUsersService UsersService { get; }

        public IVehicleEventsService VehicleEventsService { get; }

        public IVehiclesService VehiclesService { get; }
    }
}
