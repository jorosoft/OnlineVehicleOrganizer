using NUnit.Framework;
using OVO.Web.Controllers;
using System.Web.Mvc;

namespace OVO.Tests.WebTests.ControllersTests.Home
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var sut = new HomeController();

            // Act
            var result = sut.Index() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
