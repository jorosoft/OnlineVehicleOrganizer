using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.UsersServiceTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<User>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new UsersService(repoMock, saveContextStub);
            var arg = new User();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Add(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<User>>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new UsersService(repoStub, saveContextMock);
            var arg = new User();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }
    }
}
