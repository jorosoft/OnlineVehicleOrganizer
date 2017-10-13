using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Vehicle
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var manufacturersServiceStub = new Mock<IManufacturersService>().Object;
            var modelsServiceStub = new Mock<IModelsService>().Object;
            var vehiclesServiceStub = new Mock<IVehiclesService>().Object;
            var sut = new VehicleController(vehiclesServiceStub, manufacturersServiceStub, modelsServiceStub);

            // Act
            var result = sut.All() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
