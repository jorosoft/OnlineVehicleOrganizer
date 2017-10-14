using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;
using OVO.Services.Contracts;

namespace OVO.Tests.ServicesTests.DataServicesTests.ModelsServiceTests
{
    [TestFixture]
    class GetDbModel_Should
    {
        [Test]
        public void CreateDbModelInstance_WhenCalled()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<Model>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new ModelsService(repoStub, saveContextStub);

            // Act
            var result = sut.GetDbModel();

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<Model>(result);
        }
    }
}
