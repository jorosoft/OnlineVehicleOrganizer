using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.VehiclesServiceTests
{
    [TestFixture]
    public class Delete_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<Vehicle>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new VehiclesService(repoMock, saveContextStub);
            var arg = new Vehicle();

            // Act
            sut.Delete(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Delete(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<Vehicle>>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new VehiclesService(repoStub, saveContextMock);
            var arg = new Vehicle();

            // Act
            sut.Delete(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }
    }
}
