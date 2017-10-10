using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.ViewModels.Account;

namespace OVO.Tests.WebTests.ViewModelsTests.Account
{
    [TestFixture]
    public class SendCodeViewModelTests
    {
        [Test]
        public void SelectedProviderProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new SendCodeViewModel();
            var expected = "provider";

            // Act
            sut.SelectedProvider = expected;

            // Assert
            Assert.AreEqual(expected, sut.SelectedProvider);
        }

        [Test]
        public void ReturnUrlProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new SendCodeViewModel();
            var expected = "/";

            // Act
            sut.ReturnUrl = expected;

            // Assert
            Assert.AreEqual(expected, sut.ReturnUrl);
        }

        [Test]
        public void RememberMeProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new SendCodeViewModel();
            var expected = true;

            // Act
            sut.RememberMe = expected;

            // Assert
            Assert.IsTrue(sut.RememberMe);
        }

        [Test]
        public void ProvidersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new SendCodeViewModel();
            var expected = new List<System.Web.Mvc.SelectListItem>();

            // Act
            sut.Providers = expected;

            // Assert
            Assert.NotNull(sut.Providers);
            Assert.IsInstanceOf<ICollection<System.Web.Mvc.SelectListItem>>(sut.Providers);
        }
    }
}
