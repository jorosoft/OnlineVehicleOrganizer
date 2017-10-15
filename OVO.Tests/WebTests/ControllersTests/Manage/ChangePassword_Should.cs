using System.Web.Mvc;
using NUnit.Framework;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Manage
{
    [TestFixture]
    public class ChangePassword_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var sut = new ManageController();

            // Act
            var result = sut.ChangePassword();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
