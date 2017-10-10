using OVO.Services.DataServices;

namespace OVO.Services.Contracts
{
    public interface IDataService
    {
        ICronJobsService CronJobsService { get; }

        IManufacturersService ManufacturersService { get; }

        IModelsService ModelsService { get; }

        IUsersService UsersService { get; }

        IVehiclesService VehiclesService { get; }

        IVehicleEventsService VehicleEventsService { get; }
    }
}
