using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Users
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange
            var usersServiceStub = Mock.Create<IUsersService>();
            var rolesServiceStub = Mock.Create<IRolesService>();

            // Act
            var sut = new UsersController(usersServiceStub, rolesServiceStub);

            // Assert
            Assert.NotNull(sut);
            Assert.IsInstanceOf<UsersController>(sut);
        }
    }
}
