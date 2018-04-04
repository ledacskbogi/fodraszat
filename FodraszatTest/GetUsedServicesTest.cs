using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;
using NSubstitute;
using System.Collections.Generic;

namespace FodraszatTest
{
    [TestClass]
    public class GetUsedServicesTest
    {
        [TestMethod]
        public void ExecuteTest_01()
        {
            //Arrange

            // UsedServiceRepository objektum mockolása
            var usedServiceRepositoryMock = Substitute.For<IUsedServiceRepository>();
            var services = new List<ServiceModel>();
            services.Add(new ServiceModel { Id = ServiceKey.Hajvagas, Name = "Hajvágás", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.BalayageMelir, Name = "Balayage melír", TaxRate = 27 });
            usedServiceRepositoryMock.GetByCustomerId("01").Returns(services);

            // CustomerManager objektum mockolása
            var customerManagerMock = Substitute.For<ICustomerManager>();
            var customers = new List<CustomerModel>();
            customers.Add(new CustomerModel { Id = "01", Name = "Kiss Macska", BithDate = new DateTime(1990, 05, 01) });
            customerManagerMock.GetAll().Returns(customers);

            var getUsedServices = new GetUsedServices(usedServiceRepositoryMock, customerManagerMock);

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
            // Arrange
            // UsedServiceRepository objektum mockolása
            var usedServiceRepositoryMock = Substitute.For<IUsedServiceRepository>();
            var services = new List<ServiceModel>();
            services.Add(new ServiceModel { Id = ServiceKey.Hajszaritas, Name = "Hajszárítás", TaxRate = 27 });
            usedServiceRepositoryMock.GetByCustomerId("02").Returns(services);

            // CustomerManager objektum mockolása
            var customerManagerMock = Substitute.For<ICustomerManager>();
            var customers = new List<CustomerModel>();
            customers.Add(new CustomerModel { Id = "02", Name = "Kiss Kutya", BithDate = new DateTime(2010, 05, 01) });
            customerManagerMock.GetAll().Returns(customers);

            var getUsedServices = new GetUsedServices(usedServiceRepositoryMock, customerManagerMock);


            //Act
            var result = getUsedServices.Execute("02");

            //Assert
            Assert.AreEqual(ServiceKey.Hajszaritas, result[0].Id);
            Assert.AreEqual("Hajszárítás", result[0].Name);
            Assert.AreEqual(27, result[0].TaxRate);
        }

        [TestMethod]
        public void ExecuteTest_04()
        {
            // Arrange
            // UsedServiceRepository objektum mockolása
            var usedServiceRepositoryMock = Substitute.For<IUsedServiceRepository>();

            // CustomerManager objektum mockolása
            var customerManagerMock = Substitute.For<ICustomerManager>();
            var customers = new List<CustomerModel>();
            customers.Add(new CustomerModel { Id = "01", Name = "Kiss Macska", BithDate = new DateTime(2010, 05, 01) });
            customers.Add(new CustomerModel { Id = "02", Name = "Kiss Kutya", BithDate = new DateTime(2010, 05, 01) });
            customers.Add(new CustomerModel { Id = "03", Name = "Kiss Malac", BithDate = new DateTime(2010, 05, 01) });
            customerManagerMock.GetAll().Returns(customers);

            var getUsedServices = new GetUsedServices(usedServiceRepositoryMock, customerManagerMock);

            //Act, Assert
            // Assert.Throws<Exception>(() => getUsedServices.Execute("03"));

            try
            {
                //Act
                getUsedServices.Execute("04");

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
