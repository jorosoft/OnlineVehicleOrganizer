using System;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;
using System.Collections.Generic;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
{
    [TestFixture]
    public class VehicleViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void ManufacturerIdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.ManufacturerId = expected;

            // Assert
            Assert.AreEqual(expected, sut.ManufacturerId);
        }

        [Test]
        public void ModelIdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.ModelId = expected;

            // Assert
            Assert.AreEqual(expected, sut.ModelId);
        }

        [Test]
        public void ModelNameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = "model";

            // Act
            sut.ModelName = expected;

            // Assert
            Assert.AreEqual(expected, sut.ModelName);
        }

        [Test]
        public void ManufacturerNameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = "manufacturer";

            // Act
            sut.ManufacturerName = expected;

            // Assert
            Assert.AreEqual(expected, sut.ManufacturerName);
        }

        [Test]
        public void RegNumberProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = "PB1616AH";

            // Act
            sut.RegNumber = expected;

            // Assert
            Assert.AreEqual(expected, sut.RegNumber);
        }

        [Test]
        public void InsuranceDateProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = new DateTime(2017, 05, 05, 00, 00, 00);

            // Act
            sut.InsuranceDate = expected;

            // Assert
            Assert.AreEqual(expected, sut.InsuranceDate);
        }

        [Test]
        public void ServiceDateProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = new DateTime(2017, 05, 05, 00, 00, 00);

            // Act
            sut.ServiceDate = expected;

            // Assert
            Assert.AreEqual(expected, sut.ServiceDate);
        }

        [Test]
        public void VehicleEventsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = new List<VehicleEventViewModel>();

            // Act
            sut.VehicleEvents = expected;

            // Assert
            Assert.NotNull(sut.VehicleEvents);
            Assert.IsInstanceOf<IEnumerable<VehicleEventViewModel>>(sut.VehicleEvents);
        }

        [Test]
        public void CronJobsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new VehicleViewModel();
            var expected = new List<CronJobViewModel>();

            // Act
            sut.CronJobs = expected;

            // Assert
            Assert.NotNull(sut.CronJobs);
            Assert.IsInstanceOf<IEnumerable<CronJobViewModel>>(sut.CronJobs);
        }
    }
}
