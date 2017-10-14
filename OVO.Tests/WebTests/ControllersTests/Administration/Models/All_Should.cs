using System.Web.Mvc;
using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Models
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var modelssServiceStub = Mock.Create<IModelsService>();
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();
            var sut = new ModelsController(modelssServiceStub, manufacturersServiceStub);

            // Act
            var result = sut.All() as ActionResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
