using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class VerifyPhoneNumberViewModelTests
    {
        [Test]
        public void CodeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyPhoneNumberViewModel();
            var expected = "code";

            // Act
            sut.Code = expected;

            // Assert
            Assert.AreEqual(expected, sut.Code);
        }

        [Test]
        public void PhoneNumberProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VerifyPhoneNumberViewModel();
            var expected = "code";

            // Act
            sut.PhoneNumber = expected;

            // Assert
            Assert.AreEqual(expected, sut.PhoneNumber);
        }
    }
}
