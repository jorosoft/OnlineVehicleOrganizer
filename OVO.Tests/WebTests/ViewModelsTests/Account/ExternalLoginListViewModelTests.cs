using NUnit.Framework;
using OVO.Web.ViewModels.Account;

namespace OVO.Tests.WebTests.ViewModelsTests.Account
{
    [TestFixture]
    public class ExternalLoginListViewModelTests
    {
        [Test]
        public void ReturnUrlProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ExternalLoginListViewModel();
            var expected = "/";

            // Act
            sut.ReturnUrl = expected;

            // Assert
            Assert.AreEqual(expected, sut.ReturnUrl);
        }
    }
}
