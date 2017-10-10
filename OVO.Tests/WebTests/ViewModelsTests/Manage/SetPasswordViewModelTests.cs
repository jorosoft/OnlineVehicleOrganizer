using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class SetPasswordViewModelTests
    {
        [Test]
        public void NewPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new SetPasswordViewModel();
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
            var sut = new SetPasswordViewModel();
            var expected = "password";

            // Act
            sut.ConfirmPassword = expected;

            // Assert
            Assert.AreEqual(expected, sut.ConfirmPassword);
        }
    }
}
