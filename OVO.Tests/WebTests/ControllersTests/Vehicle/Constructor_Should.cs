using NUnit.Framework;
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
            var sut = new VehicleController(
                vehiclesServiceStub, 
                manufacturersServiceStub, 
                modelsServiceStub,
                usersServiceStub);

            // Assert
            Assert.IsNotNull(sut);
        }
    }
}
