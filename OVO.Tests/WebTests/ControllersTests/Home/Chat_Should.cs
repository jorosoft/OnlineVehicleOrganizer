using System.Web.Mvc;
using NUnit.Framework;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Home
{
    [TestFixture]
    public class Chat_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var sut = new HomeController();

            // Act
            var result = sut.Chat() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
