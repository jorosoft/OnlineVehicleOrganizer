using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class ManufacturersListViewModelTests
    {
        [Test]
        public void ManufacturersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManufacturersListViewModel();
            var expected = new List<ManufacturerViewModel>();

            // Act
            sut.Manufacturers = expected;

            // Assert
            Assert.NotNull(sut.Manufacturers);
            Assert.IsInstanceOf<IEnumerable<ManufacturerViewModel>>(sut.Manufacturers);
            Assert.AreSame(expected, sut.Manufacturers);
        }
    }
}
