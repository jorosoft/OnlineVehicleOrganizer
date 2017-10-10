using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class ConfigureTwoFactorViewModelTests
    {
        [Test]
        public void SelectedProviderProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ConfigureTwoFactorViewModel();
            var expected = "myProvider";

            // Act
            sut.SelectedProvider = expected;

            // Assert
            Assert.AreEqual(expected, sut.SelectedProvider);
        }

        [Test]
        public void ProvidersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ConfigureTwoFactorViewModel();
            var expected = new List<System.Web.Mvc.SelectListItem>();

            // Act
            sut.Providers = expected;

            // Assert
            Assert.NotNull(sut.Providers);
            Assert.IsInstanceOf<ICollection<System.Web.Mvc.SelectListItem>>(sut.Providers);
        }
    }
}
