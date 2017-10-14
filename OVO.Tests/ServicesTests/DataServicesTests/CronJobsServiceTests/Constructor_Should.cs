using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.DataServices;
using OVO.Data.Contracts;
using OVO.Services.Contracts;
using OVO.Data.Models;

namespace OVO.Tests.ServicesTests.DataServicesTests.CronJobsServiceTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateInstance_WhenCalled()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<CronJob>>();
            var saveContextStub = Mock.Create<ISaveContext>();

            // Act
            var sut = new CronJobsService(repoStub, saveContextStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<ICronJobsService>(sut);
        }
    }
}
