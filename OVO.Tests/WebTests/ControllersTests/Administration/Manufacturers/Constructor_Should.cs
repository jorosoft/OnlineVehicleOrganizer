using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Manufacturers
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();

            // Act
            var sut = new ManufacturersController(manufacturersServiceStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<ManufacturersController>(sut);
        }
    }
}
