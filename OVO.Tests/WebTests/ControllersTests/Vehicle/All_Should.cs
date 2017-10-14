using System.Web.Mvc;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;
using Telerik.JustMock;

namespace OVO.Tests.WebTests.ControllersTests.Vehicle
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();
            var modelsServiceStub = Mock.Create<IModelsService>();
            var vehiclesServiceStub = Mock.Create<IVehiclesService>();
            var sut = new VehicleController(vehiclesServiceStub, manufacturersServiceStub, modelsServiceStub);

            // Act
            var result = sut.All() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
