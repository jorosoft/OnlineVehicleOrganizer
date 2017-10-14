using System.Web.Mvc;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;
using Telerik.JustMock;

namespace OVO.Tests.WebTests.ControllersTests.Account
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var usersServiceStub = Mock.Create<IUsersService>();
            var sut = new AccountController(usersServiceStub);

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<Controller>(sut);
        }
    }
}
