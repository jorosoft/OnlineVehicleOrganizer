﻿using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;
using Telerik.JustMock;

namespace OVO.Tests.WebTests.ControllersTests.Vehicle
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();
            var modelsServiceStub = Mock.Create<IModelsService>();
            var vehiclesServiceStub = Mock.Create<IVehiclesService>();
            var usersServiceStub = Mock.Create<IUsersService>();
            var vehicleEventsServiceStub = Mock.Create<IVehicleEventsService>();
            var cronJobsServiceStub = Mock.Create<ICronJobsService>();
            var sut = new VehicleController(
                vehiclesServiceStub,
                manufacturersServiceStub,
                modelsServiceStub,
                usersServiceStub,
                vehicleEventsServiceStub,
                cronJobsServiceStub);

            // Assert
            Assert.IsNotNull(sut);
        }
    }
}
