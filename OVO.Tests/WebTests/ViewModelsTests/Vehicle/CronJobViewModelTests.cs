using System;
using NUnit.Framework;
using OVO.Web.ViewModels.Vehicle;

namespace OVO.Tests.WebTests.ViewModelsTests.Vehicle
{
    [TestFixture]
    public class CronJobViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new CronJobViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void StartDateProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new CronJobViewModel();
            var expected = new DateTime(2017,05, 05, 00, 00, 00);

            // Act
            sut.StartDate = expected;

            // Assert
            Assert.AreEqual(expected, sut.StartDate);
        }

        [Test]
        public void NameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new CronJobViewModel();
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
            var sut = new CronJobViewModel();
            var expected = "ala bala";

            // Act
            sut.Description = expected;

            // Assert
            Assert.AreEqual(expected, sut.Description);
        }

        [Test]
        public void PeriodInMonthsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new CronJobViewModel();
            var expected = 17;

            // Act
            sut.PeriodInMonths = expected;

            // Assert
            Assert.AreEqual(expected, sut.PeriodInMonths);
        }

        [Test]
        public void VehicleIdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new CronJobViewModel();
            var expected = Guid.NewGuid();

            // Act
            sut.VehicleId = expected;

            // Assert
            Assert.AreEqual(expected, sut.VehicleId);
        }
    }
}
