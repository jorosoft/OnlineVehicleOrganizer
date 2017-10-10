using System.Web.Mvc;
using NUnit.Framework;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllerTests.Vehicle
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var sut = new VehicleController();

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<Controller>(sut);
        }
    }
}
