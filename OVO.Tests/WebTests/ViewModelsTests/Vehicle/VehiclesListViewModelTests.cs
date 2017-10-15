using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
{
    [TestFixture]
    public class VehiclesListViewModelTests
    {
        [Test]
        public void VehiclesProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehiclesListViewModel();
            var expected = new List<VehicleViewModel>();

            // Act
            sut.Vehicles = expected;

            // Assert
            Assert.NotNull(sut.Vehicles);
            Assert.IsInstanceOf<IEnumerable<VehicleViewModel>>(sut.Vehicles);
        }
    }
}
