using NUnit.Framework;
using OVO.Web.ViewModels.Account;

namespace OVO.Tests.WebTests.ViewModelsTests.Account
{
    [TestFixture]
    public class VerifyCodeViewModelTests
    {
        [Test]
        public void ProviderProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyCodeViewModel();
            var expected = "provider";

            // Act
            sut.Provider = expected;

            // Assert
            Assert.AreEqual(expected, sut.Provider);
        }

        [Test]
        public void CodeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyCodeViewModel();
            var expected = "code";

            // Act
            sut.Code = expected;

            // Assert
            Assert.AreEqual(expected, sut.Code);
        }

        [Test]
        public void ReturnUrlProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyCodeViewModel();
            var expected = "/home";

            // Act
            sut.ReturnUrl = expected;

            // Assert
            Assert.AreEqual(expected, sut.ReturnUrl);
        }

        [Test]
        public void RememberMeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyCodeViewModel();
            var expected = true;

            // Act
            sut.RememberMe = expected;

            // Assert
            Assert.IsTrue(sut.RememberMe);
        }

        [Test]
        public void RememberBrowserProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyCodeViewModel();
            var expected = false;

            // Act
            sut.RememberBrowser = expected;

            // Assert
            Assert.IsFalse(sut.RememberBrowser);
        }
    }
}
