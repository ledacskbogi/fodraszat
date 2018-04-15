using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;
using NSubstitute;
using System.Collections.Generic;

namespace FodraszatTest
{
    [TestClass]
    public class CreateInvoiceTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            //Arrange

            // GetUsedServices objektum mockolása
            var getUsedServices = Substitute.For<IGetUsedServices>();
            var services = new List<ServiceModel>();
            services.Add(new ServiceModel { Id = ServiceKey.Hajvagas, Name = "Hajvágás", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.Hajszaritas, Name = "Hajszárítás", TaxRate = 27 });
            getUsedServices.Execute("01").Returns(services);

            // CustomerManager objektum mockolása
            var customerManager = Substitute.For<ICustomerManager>();
            var customers = new List<CustomerModel>();
            customers.Add(new CustomerModel { Id = "01", BithDate = new DateTime(2000,5,28), Name = "Kiss Dorottya" });
            customerManager.GetAll().Returns(customers);

            // GetPrice objektum mockolása
            var getPrice = Substitute.For<IGetPrice>();
            getPrice.Execute(ServiceKey.Hajvagas).Returns(10000);
            getPrice.Execute(ServiceKey.Hajszaritas).Returns(5900);

            // Preview objektum mockolása
            var preview = Substitute.For<IPreview>();

            // CreateInvoice objektum példányosítása
            // Ez a tesztelés alatt álló objektum (ezért ez nem mock példány)
            var createInvoice = new CreateInvoice(customerManager, getUsedServices, getPrice, preview);

            //Act
            createInvoice.Execute("01");

            //Assert
            getPrice.Received(1).Execute(ServiceKey.Hajvagas);
            getPrice.Received(1).Execute(ServiceKey.Hajszaritas);
        }
    }
}
