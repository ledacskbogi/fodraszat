using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    [TestClass]
    public class GetUsedServicesTest
    {
        [TestMethod]
        public void ExecuteTest_01()
        {
            //Arrange
            var getUsedServices = new GetUsedServices(new UsedServiceRepository(new FileUtil()));

            //Act
            var result = getUsedServices.Execute("01");

            //Assert
            Assert.AreEqual(ServiceKey.Hajvagas, result[0].Id);
            Assert.AreEqual("Hajvágás", result[0].Name);
            Assert.AreEqual(27, result[0].TaxRate);
            Assert.AreEqual(ServiceKey.BalayageMelir, result[1].Id);
            Assert.AreEqual("Balayage melír", result[1].Name);
            Assert.AreEqual(27, result[1].TaxRate);
        }


        [TestMethod]
        public void ExecuteTest_02()
        {
            //Arrange
            var getUsedServices = new GetUsedServices(new UsedServiceRepository(new FileUtil()));

            //Act
            var result = getUsedServices.Execute("02");

            //Assert
            Assert.AreEqual(ServiceKey.Hajszaritas, result[0].Id);
            Assert.AreEqual("Hajszárítás", result[0].Name);
            Assert.AreEqual(27, result[0].TaxRate);
        }

        [TestMethod]
        public void ExecuteTest_03()
        {
            //Arrange
            var getUsedServices = new GetUsedServices(new UsedServiceRepository(new FileUtil()));

            //Act, Assert
            // Assert.Throws<Exception>(() => getUsedServices.Execute("03"));

            try
            {
                //Act
                getUsedServices.Execute("03");

                Assert.Fail("Not thrown the expected exception");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Nem létező ügyfél azonosító.", ex.Message);
            }
            catch (Exception)
            {
                Assert.Fail("Not thrown the expected exception");
            }
        }

    }

}
