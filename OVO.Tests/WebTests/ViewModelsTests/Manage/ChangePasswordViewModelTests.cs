using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class ChangePasswordViewModelTests
    {
        [Test]
        public void OldPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ChangePasswordViewModel();
            var expected = "password";

            // Act
            sut.OldPassword = expected;

            // Assert
            Assert.AreEqual(expected, sut.OldPassword);
        }

        [Test]
        public void NewPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ChangePasswordViewModel();
            var expected = "password";

            // Act
            sut.NewPassword = expected;

            // Assert
            Assert.AreEqual(expected, sut.NewPassword);
        }

        [Test]
        public void ConfirmPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ChangePasswordViewModel();
            var expected = "password";

            // Act
            sut.ConfirmPassword = expected;

            // Assert
            Assert.AreEqual(expected, sut.ConfirmPassword);
        }
    }
}
