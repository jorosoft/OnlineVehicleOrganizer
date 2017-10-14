using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    class RoleViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new RoleViewModel();
            var expected = "12345";

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void NameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new RoleViewModel();
            var expected = "Admin";

            // Act
            sut.Name = expected;

            // Assert
            Assert.AreEqual(expected, sut.Name);
        }
    }
}
