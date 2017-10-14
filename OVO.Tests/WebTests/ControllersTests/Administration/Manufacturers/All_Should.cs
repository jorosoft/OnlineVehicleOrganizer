using System.Web.Mvc;
using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Manufacturers
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();
            var sut = new ManufacturersController(manufacturersServiceStub);

            // Act
            var result = sut.All() as ActionResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
