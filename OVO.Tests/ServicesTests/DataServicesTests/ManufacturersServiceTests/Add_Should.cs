using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.ManufacturersServiceTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<Manufacturer>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new ManufacturersService(repoMock, saveContextStub);
            var arg = new Manufacturer();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Add(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<Manufacturer>>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new ManufacturersService(repoStub, saveContextMock);
            var arg = new Manufacturer();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }

    }
}
