﻿using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using OVO.Services.Contracts;
using OVO.Web.Controllers;

namespace OVO.Tests.WebTests.ControllersTests.Vehicle
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CreateController_WhenCalled()
        {
            // Arrange & Act
            var manufacturersServiceStub = new Mock<IManufacturersService>().Object;
            var modelsServiceStub = new Mock<IModelsService>().Object;
            var vehiclesServiceStub = new Mock<IVehiclesService>().Object;
            var sut = new VehicleController(vehiclesServiceStub, manufacturersServiceStub, modelsServiceStub);

            // Assert
            Assert.IsNotNull(sut);
            Assert.IsInstanceOf<Controller>(sut);
        }
    }
}
