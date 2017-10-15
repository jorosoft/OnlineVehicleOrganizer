using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
{
    [TestFixture]
    public class VehicleExtendedViewModelTests
    {
        [Test]
        public void ManufacturersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleExtendedViewModel();
            var expected = new List<ManufacturerViewModel>();

            // Act
            sut.Manufacturers = expected;

            // Assert
            Assert.NotNull(sut.Manufacturers);
            Assert.IsInstanceOf<IEnumerable<ManufacturerViewModel>>(sut.Manufacturers);
        }

        [Test]
        public void ModelsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleExtendedViewModel();
            var expected = new List<ModelViewModel>();

            // Act
            sut.Models = expected;

            // Assert
            Assert.NotNull(sut.Models);
            Assert.IsInstanceOf<IEnumerable<ModelViewModel>>(sut.Models);
        }
    }
}
