using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    /// <summary>
    /// Summary description for UsedServiceRepositoryTest
    /// </summary>
    [TestClass]
    public class UsedServiceRepositoryTest
    {
        [TestMethod]
        public void Save()
        {
            // Arrange
            var usedServiceRepository = new UsedServiceRepository(new FileUtil());

            // Act
            usedServiceRepository.Save("01", new ServiceModel { Id = ServiceKey.Hajfestes, Name = "Hajfestés", TaxRate = 27 });

            // Assert
        }

    }

}
