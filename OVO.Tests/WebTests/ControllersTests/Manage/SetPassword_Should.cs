using System.Web.Mvc;
using NUnit.Framework;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Manage
{
    [TestFixture]
    public class SetPassword_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var sut = new ManageController();

            // Act
            var result = sut.SetPassword();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
