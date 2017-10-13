using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Account
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var usersServiceStub = new Mock<IUsersService>().Object;
            var sut = new AccountController(usersServiceStub);
            
            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<Controller>(sut);
        }
    }
}
