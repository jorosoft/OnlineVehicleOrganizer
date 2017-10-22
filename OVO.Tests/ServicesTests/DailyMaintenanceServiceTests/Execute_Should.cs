using NUnit.Framework;
using OVO.Data.Models;
using OVO.Services;
using OVO.Services.Contracts;
using System.Linq;
using Telerik.JustMock;

namespace OVO.Tests.ServicesTests.DailyMaintenanceServiceTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void CallVehiclesServiceTwice_WithCorrectData()
        {
            // Arrange
            var emailServiceStub = Mock.Create<IEmailSendService>();
            var vehiclesServiceMock = Mock.Create<IVehiclesService>();
            var sut = new DailyMaintenanceService(emailServiceStub, vehiclesServiceMock);

            // Act 
            var result = sut.Execute();

            // Assert
            Mock.Assert(() => vehiclesServiceMock.GetAll(), Occurs.Exactly(2));
        }        
    }
}
