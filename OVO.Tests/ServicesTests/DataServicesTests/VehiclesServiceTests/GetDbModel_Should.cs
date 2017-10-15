using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;
using OVO.Services.Contracts;

namespace OVO.Tests.ServicesTests.DataServicesTests.VehiclesServiceTests
{
    [TestFixture]
    public class GetDbModel_Should
    {
        [Test]
        public void CreateDbModelInstance_WhenCalled()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<Vehicle>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new VehiclesService(repoStub, saveContextStub);

            // Act
            var result = sut.GetDbModel();

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<Vehicle>(result);
        }
    }
}
