using System;
using System.Collections.Generic;
using NUnit.Framework;
using OVO.Web.Areas.Administration.ViewModels;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Tests.WebTests.ViewModelsTests.Administration
{
    [TestFixture]
    public class UserViewModelTests
    {
        [Test]
        public void IdProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = "12345";

            // Act
            sut.Id = expected;

            // Assert
            Assert.AreEqual(expected, sut.Id);
        }

        [Test]
        public void UsernameProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = "username";

            // Act
            sut.Username = expected;

            // Assert
            Assert.AreEqual(expected, sut.Username);
        }

        [Test]
        public void EmailProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = "ala@bala.com";

            // Act
            sut.Email = expected;

            // Assert
            Assert.AreEqual(expected, sut.Email);
        }

        [Test]
        public void RoleProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = "User";

            // Act
            sut.Role = expected;

            // Assert
            Assert.AreEqual(expected, sut.Role);
        }

        [Test]
        public void IsDeletedProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = true;

            // Act
            sut.IsDeleted = expected;

            // Assert
            Assert.IsTrue(sut.IsDeleted);
        }

        [Test]
        public void DeletedOnProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = new DateTime(2017, 05, 02, 12, 0 , 0);

            // Act
            sut.DeletedOn = expected;

            // Assert
            Assert.AreEqual(expected, sut.DeletedOn);
        }

        [Test]
        public void CreatedOnProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = new DateTime(2017, 05, 02, 12, 0, 0);

            // Act
            sut.CreatedOn = expected;

            // Assert
            Assert.AreEqual(expected, sut.CreatedOn);
        }

        [Test]
        public void ModifiedOnProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = new DateTime(2017, 05, 02, 12, 0, 0);

            // Act
            sut.ModifiedOn = expected;

            // Assert
            Assert.AreEqual(expected, sut.ModifiedOn);
        }

        [Test]
        public void RolesProperty_ShouldSetCorrectValue_WithCorrectData()
        {
            // Arrange
            var sut = new UserViewModel();
            var expected = new List<RoleViewModel>();

            // Act
            sut.Roles = expected;

            // Assert
            Assert.NotNull(sut.Roles);
            Assert.IsInstanceOf<List<RoleViewModel>>(sut.Roles);
            Assert.AreSame(expected, sut.Roles);
        }
    }
}
