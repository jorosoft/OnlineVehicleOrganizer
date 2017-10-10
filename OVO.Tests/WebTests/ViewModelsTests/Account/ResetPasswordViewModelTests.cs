using NUnit.Framework;
using OVO.Web.ViewModels.Account;

namespace OVO.Tests.WebTests.ViewModelsTests.Account
{
    [TestFixture]
    public class ResetPasswordViewModelTests
    {
        [Test]
        public void EmailProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ResetPasswordViewModel();
            var expected = "admin@ovo.com";

            // Act
            sut.Email = expected;

            // Assert
            Assert.AreEqual(expected, sut.Email);
        }

        [Test]
        public void PasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ResetPasswordViewModel();
            var expected = "AlaBala12345*";

            // Act
            sut.Password = expected;

            // Assert
            Assert.AreEqual(expected, sut.Password);
        }

        [Test]
        public void ConfirmPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ResetPasswordViewModel();
            var expected = "AlaBala12345*";

            // Act
            sut.ConfirmPassword = expected;

            // Assert
            Assert.AreEqual(expected, sut.ConfirmPassword);
        }

        [Test]
        public void CodeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ResetPasswordViewModel();
            var expected = "code";

            // Act
            sut.Code = expected;

            // Assert
            Assert.AreEqual(expected, sut.Code);
        }
    }
}
