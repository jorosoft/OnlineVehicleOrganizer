using System;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
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
            var expected = "name";

            // Act
            sut.Name = expected;

            // Assert
            Assert.AreEqual(expected, sut.Name);
        }
    }
}
