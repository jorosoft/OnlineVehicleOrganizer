using Microsoft.AspNet.Identity;
using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Services.DataServices;
using OVO.Data.Models;

namespace OVO.Tests.ServicesTests.DataServicesTests.RolesServiceTests
{
    [TestFixture]
    public class UserManager_Should
    {
        [Test]
        public void BeInitialized_WhenRolesServiceIsCreated()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRoleRepository>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new RolesService(repoStub, saveContextStub);

            // Act & Assert
            Assert.NotNull(sut.UserManager);
            Assert.IsInstanceOf<UserManager<User>>(sut.UserManager);
        }
    }
}
