using System.Web.Mvc;
using NUnit.Framework;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllerTests.Manage
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var sut = new ManageController();

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<Controller>(sut);
        }
    }
}
