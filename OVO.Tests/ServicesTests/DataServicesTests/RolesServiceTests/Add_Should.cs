using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OVO.Tests.ServicesTests.DataServicesTests.RolesServiceTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRoleRepository>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new RolesService(repoMock, saveContextStub);
            var arg = new IdentityRole();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Add(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRoleRepository>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new RolesService(repoStub, saveContextMock);
            var arg = new IdentityRole();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }
    }
}
