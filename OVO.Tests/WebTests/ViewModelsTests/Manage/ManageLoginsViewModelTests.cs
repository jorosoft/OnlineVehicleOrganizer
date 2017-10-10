using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using NUnit.Framework;
using OVO.Web.ViewModels.Manage;

namespace OVO.Tests.WebTests.ViewModelsTests.Manage
{
    [TestFixture]
    public class ManageLoginsViewModelTests
    {
        [Test]
        public void CurrentLoginsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManageLoginsViewModel();
            var expected = new List<UserLoginInfo>();

            // Act
            sut.CurrentLogins = expected;

            // Assert
            Assert.NotNull(sut.CurrentLogins);
            Assert.IsInstanceOf<IList<UserLoginInfo>>(sut.CurrentLogins);
        }

        [Test]
        public void OtherLoginsProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new ManageLoginsViewModel();
            var expected = new List<AuthenticationDescription>();

            // Act
            sut.OtherLogins = expected;

            // Assert
            Assert.NotNull(sut.OtherLogins);
            Assert.IsInstanceOf<IList<AuthenticationDescription>>(sut.OtherLogins);
        }
    }
}
