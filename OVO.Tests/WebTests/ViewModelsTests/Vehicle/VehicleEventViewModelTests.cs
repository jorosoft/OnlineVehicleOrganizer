using System;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
{
    [TestFixture]
    public class VehicleEventViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleEventViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void DateProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleEventViewModel();
            var expected = new DateTime(2017, 06, 08, 00, 00, 00);

            // Act
            sut.Date = expected;

            // Assert
            Assert.AreEqual(expected, sut.Date);
        }
        [Test]
        public void NameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleEventViewModel();
            var expected = "Name";

            // Act
            sut.Name = expected;

            // Assert
            Assert.AreEqual(expected, sut.Name);
        }
        [Test]
        public void DescriptionProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleEventViewModel();
            var expected = "Description";

            // Act
            sut.Description = expected;

            // Assert
            Assert.AreEqual(expected, sut.Description);
        }
        [Test]
        public void VehicleIdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleEventViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.VehicleId = expected;

            // Assert
            Assert.AreEqual(expected, sut.VehicleId);
        }
    }
}
