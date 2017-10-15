﻿using System.Web.Mvc;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;
using Telerik.JustMock;

namespace OVO.Tests.WebTests.ControllersTests.Account
{
    [TestFixture]
    public class Register_Should
    {
        [Test]
        public void ReturnNotNull_WhenCalled()
        {
            // Arrange
            var usersServiceStub = Mock.Create<IUsersService>();
            var sut = new AccountController(usersServiceStub);

            // Act
            var result = sut.Register() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
