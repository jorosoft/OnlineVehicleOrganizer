using System;
using System.Web.Mvc;
using NUnit.Framework;
using Telerik.JustMock;
using OVO.Web.Controllers;
using OVO.Services.Contracts;

namespace OVO.Tests.WebTests.ControllersTests.Vehicle
{
    [TestFixture]
    public class AddCronJob_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
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

            // Act
            var result = sut.AddCronJob(Guid.NewGuid()) as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}