using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;
using OVO.Services.Contracts;

namespace OVO.Tests.ServicesTests.DataServicesTests.CronJobsServiceTests
{
    [TestFixture]
    public class GetDbModel_Should
    {
        [Test]
        public void CreateDbModelInstance_WhenCalled()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<CronJob>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new CronJobsService(repoStub, saveContextStub);

            // Act
            var result = sut.GetDbModel();

            // Assert
            Assert.NotNull(result);
            Assert.IsInstanceOf<CronJob>(result);
        }
    }
}
