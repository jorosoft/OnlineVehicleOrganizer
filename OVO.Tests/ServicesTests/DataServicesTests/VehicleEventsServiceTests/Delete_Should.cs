using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.VehicleEventsServiceTests
{
    [TestFixture]
    public class Delete_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<VehicleEvent>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new VehicleEventsService(repoMock, saveContextStub);
            var arg = new VehicleEvent();

            // Act
            sut.Delete(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Delete(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<VehicleEvent>>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new VehicleEventsService(repoStub, saveContextMock);
            var arg = new VehicleEvent();

            // Act
            sut.Delete(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }
    }
}
