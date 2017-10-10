using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class AddPhoneNumberViewModelTests
    {
        [Test]
        public void NumberProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new AddPhoneNumberViewModel();
            var expected = "12345";

            // Act
            sut.Number = expected;

            // Assert
            Assert.AreEqual(expected, sut.Number);
        }
    }
}
