using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.UsersServiceTests
{
    [TestFixture]
    public class GetAllAndDeleted_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<User>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new UsersService(repoMock, saveContextStub);

            // Act
            sut.GetAllAndDeleted();

            // Act & Assert
            Mock.Assert(() => repoMock.AllAndDeleted, Occurs.Once());
        }
    }
}
