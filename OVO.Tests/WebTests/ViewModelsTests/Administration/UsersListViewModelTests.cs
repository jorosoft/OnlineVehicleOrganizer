using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class UsersListViewModelTests
    {
        [Test]
        public void UsersProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UsersListViewModel();
            var expected = new List<UserViewModel> ();

            // Act
            sut.Users = expected;

            // Assert
            Assert.NotNull(sut.Users);
            Assert.IsInstanceOf<IEnumerable<UserViewModel>>(sut.Users);
            Assert.AreSame(expected, sut.Users);
        }
    }
}
