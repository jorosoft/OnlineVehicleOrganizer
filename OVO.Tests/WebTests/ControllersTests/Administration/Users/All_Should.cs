using System.Web.Mvc;
using NUnit.Framework;
using Telerik.JustMock;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Administration.Users
{
    [TestFixture]
    public class All_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var usersServiceStub = Mock.Create<IUsersService>();
            var rolesServiceStub = Mock.Create<IRolesService>();
            var sut = new UsersController(usersServiceStub, rolesServiceStub);

            // Act
            var result = sut.All() as ActionResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
