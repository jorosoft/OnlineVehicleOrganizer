﻿using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Data.Models;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.CronJobsServiceTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRepository<CronJob>>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new CronJobsService(repoMock, saveContextStub);
            var arg = new CronJob();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => repoMock.Add(arg), Occurs.Once());
        }

        [Test]
        public void CallOnceCommit_WithCorrectData()
        {
            // Arrange
            var repoStub = Mock.Create<IEfRepository<CronJob>>();
            var saveContextMock = Mock.Create<ISaveContext>();
            var sut = new CronJobsService(repoStub, saveContextMock);
            var arg = new CronJob();

            // Act
            sut.Add(arg);

            // Act & Assert
            Mock.Assert(() => saveContextMock.Commit(), Occurs.Once());
        }
    }
}
