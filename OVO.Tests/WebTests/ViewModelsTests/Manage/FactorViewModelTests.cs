using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class FactorViewModelTests
    {
        [Test]
        public void PurposeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new FactorViewModel();
            var expected = "login";

            // Act
            sut.Purpose = expected;

            // Assert
            Assert.AreEqual(expected, sut.Purpose);
        }
    }
}
