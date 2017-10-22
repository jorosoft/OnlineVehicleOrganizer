using NUnit.Framework;
using OVO.Services.Enumerations;
using OVO.Services.Models;

namespace OVO.Tests.ServicesTests
{
    [TestFixture]
    public class MailModelTests
    {
        [Test]
        public void DayProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = 13;

            // Act
            sut.Day = expected;

            // Assert
            Assert.AreEqual(expected, sut.Day);
        }

        [Test]
        public void MonthProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = 3;

            // Act
            sut.Month = expected;

            // Assert
            Assert.AreEqual(expected, sut.Month);
        }

        [Test]
        public void ManufacturerProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = "BMW";

            // Act
            sut.Manufacturer = expected;

            // Assert
            Assert.AreEqual(expected, sut.Manufacturer);
        }

        [Test]
        public void ModelProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = "Passat";

            // Act
            sut.Model = expected;

            // Assert
            Assert.AreEqual(expected, sut.Model);
        }

        [Test]
        public void RegNumberProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = "CA1111PB";

            // Act
            sut.RegNumber = expected;

            // Assert
            Assert.AreEqual(expected, sut.RegNumber);
        }

        [Test]
        public void DestinationEmailProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = "ala@bala.com";

            // Act
            sut.DestinationEmail = expected;

            // Assert
            Assert.AreEqual(expected, sut.DestinationEmail);
        }

        [Test]
        public void MailTypeProperty_ShouldReturnCorrectValue_WithCorrectDataGiven()
        {
            // Arrange
            var sut = new Mail();
            var expected = MailType.InsuranceMail;

            // Act
            sut.MailType = expected;

            // Assert
            Assert.AreEqual(expected, sut.MailType);
        }
    }
}
