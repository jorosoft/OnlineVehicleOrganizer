using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.DataServices;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.Contracts;

namespace OVO.Tests.ServicesTests.DataServicesTests.ManufacturersServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateInstance_WhenCalled()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<Manufacturer>>();
            var saveContextStub = Mock.Create<ISaveContext>();

            // Act
            var sut = new ManufacturersService(repoStub, saveContextStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<IManufacturersService>(sut);
        }
    }
}
