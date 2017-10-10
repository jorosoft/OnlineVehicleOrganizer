using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class IndexViewModelTests
    {
        [Test]
        public void PhoneNumberProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new IndexViewModel();
            var expected = "123456";

            // Act
            sut.PhoneNumber = expected;

            // Assert
            Assert.AreEqual(expected, sut.PhoneNumber);
        }

        [Test]
        public void HasPasswordProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new IndexViewModel();
            var expected = false;

            // Act
            sut.HasPassword = expected;

            // Assert
            Assert.IsFalse(sut.HasPassword);
        }

        [Test]
        public void TwoFactorProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new IndexViewModel();
            var expected = false;

            // Act
            sut.TwoFactor = expected;

            // Assert
            Assert.IsFalse(sut.TwoFactor);
        }

        [Test]
        public void BrowserRememberedProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new IndexViewModel();
            var expected = false;

            // Act
            sut.BrowserRemembered = expected;

            // Assert
            Assert.IsFalse(sut.BrowserRemembered);
        }

        [Test]
        public void LoginsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new IndexViewModel();
            var expected = new List<UserLoginInfo>();

            // Act
            sut.Logins = expected;

            // Assert
            Assert.NotNull(sut.Logins);
            Assert.IsInstanceOf<IList<UserLoginInfo>>(sut.Logins);
        }
    }
}
