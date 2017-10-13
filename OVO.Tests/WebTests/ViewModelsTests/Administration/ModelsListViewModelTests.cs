using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class ModelsListViewModelTests
    {
        [Test]
        public void ModelsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ModelsListViewModel();
            var expected = new List<ModelViewModel>();

            // Act
            sut.Models = expected;

            // Assert
            Assert.NotNull(sut.Models);
            Assert.IsInstanceOf<IEnumerable<ModelViewModel>>(sut.Models);
            Assert.AreSame(expected, sut.Models);
        }
    }
}
