using NUnit.Framework;
using OVO.Web.ViewModels.Account;

namespace OVO.Tests.WebTests.ViewModelsTests.Account
{
    [TestFixture]
    public class ForgotPasswordViewModelTests
    {
        [Test]
        public void EmailProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ForgotPasswordViewModel();
            var expected = "admin@ovo.com";

            // Act
            sut.Email = expected;

            // Assert
            Assert.AreEqual(expected, sut.Email);
        }
    }
}
