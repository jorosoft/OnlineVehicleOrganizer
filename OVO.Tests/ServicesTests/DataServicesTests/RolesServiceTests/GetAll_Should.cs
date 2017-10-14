using NUnit.Framework;
using Telerik.JustMock;
using OVO.Data.Contracts;
using OVO.Services.DataServices;

namespace OVO.Tests.ServicesTests.DataServicesTests.RolesServiceTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void CallOnceRepo_WithCorrectData()
        {
            // Arrange
            var repoMock = Mock.Create<IEfRoleRepository>();
            var saveContextStub = Mock.Create<ISaveContext>();
            var sut = new RolesService(repoMock, saveContextStub);

            // Act
            sut.GetAll();

            // Act & Assert
            Mock.Assert(() => repoMock.All, Occurs.Once());
        }

    }
}
