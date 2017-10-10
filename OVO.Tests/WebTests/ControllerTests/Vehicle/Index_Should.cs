using NUnit.Framework;
using OVO.Web.Controllers;
using System.Web.Mvc;

namespace OVO.Tests.WebTests.ControllerTests.Vehicle
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var sut = new VehicleController();

            // Act
            var result = sut.Index() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
