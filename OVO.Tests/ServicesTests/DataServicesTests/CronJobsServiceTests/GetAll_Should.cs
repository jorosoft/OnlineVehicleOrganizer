using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.CronJobsServiceTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<CronJob>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new CronJobsService(repoMock, saveContextStub);

            // Act
            sut.GetAll();

            // Act & Assert
            Mock.Assert(() => repoMock.All, Occurs.Once());
        }    
    }
}
