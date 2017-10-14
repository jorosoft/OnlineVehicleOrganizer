using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Models
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange
            var modelsServiceStub = Mock.Create<IModelsService>();
            var manufacturersServiceStub = Mock.Create<IManufacturersService>();

            // Act
            var sut = new ModelsController(modelsServiceStub, manufacturersServiceStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<ModelsController>(sut);
        }
    }
}
