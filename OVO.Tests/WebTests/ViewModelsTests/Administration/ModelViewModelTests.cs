using System;
using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class ModelViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void ManufacturersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelViewModel();
            var expected = new List<ManufacturerViewModel>();

            // Act
            sut.Manufacturers = expected;

            // Assert
            Assert.NotNull(sut.Manufacturers);
            Assert.IsInstanceOf<IEnumerable<ManufacturerViewModel>>(sut.Manufacturers);
            Assert.AreSame(expected, sut.Manufacturers);
        }

        [Test]
        public void ModelNameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelViewModel();
            var expected = "modelname";

            // Act
            sut.ModelName = expected;

            // Assert
            Assert.AreEqual(expected, sut.ModelName);
        }

        [Test]
        public void ManufacturerNameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelViewModel();
            var expected = "manufacturer";

            // Act
            sut.ManufacturerName = expected;

            // Assert
            Assert.AreEqual(expected, sut.ManufacturerName);
        }

        [Test]
        public void IsDeletedProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelViewModel();
            var expected = false;

            // Act
            sut.IsDeleted = expected;

            // Assert
            Assert.False(sut.IsDeleted);
        }
    }
}
