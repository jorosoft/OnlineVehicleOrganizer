using NUnit.Framework;
using OVO.Services;
using OVO.Services.Contracts;
using Telerik.JustMock;

namespace OVO.Tests.ServicesTests.DailyMaintenanceServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateNotNullObject_WithCorrectData()
        {
            // Arrange
            var emailServiceStub = Mock.Create<IEmailSendService>();
            var vehiclesServiceStub = Mock.Create<IVehiclesService>();

            // Act 
            var sut = new DailyMaintenanceService(emailServiceStub, vehiclesServiceStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<IDailyMaintenanceService>(sut);
        }
    }
}
