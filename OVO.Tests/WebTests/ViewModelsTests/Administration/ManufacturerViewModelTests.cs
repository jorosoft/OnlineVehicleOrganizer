using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;
using System;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class ManufacturerViewModelTests
    {

        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManufacturerViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void NameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManufacturerViewModel();
            var expected = "manufacturer";

            // Act
            sut.Name = expected;

            // Assert
            Assert.AreEqual(expected, sut.Name);
        }

        [Test]
        public void IsDeletedProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManufacturerViewModel();
            var expected = false;

            // Act
            sut.IsDeleted = expected;

            // Assert
            Assert.False(sut.IsDeleted);
        }
    }
}
