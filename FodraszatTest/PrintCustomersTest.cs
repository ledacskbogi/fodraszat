using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;
using System.Collections.Generic;

namespace FodraszatTest
{
    [TestClass]
    public class PrintCustomersTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            //Arrange
            var printCustomers = new PrintCustomers();
            var customers = new List<CustomerModel>();
            var customer = new CustomerModel();
            customer.Id = "01";
            customer.Name = "Mézga Géza";
            customer.BithDate = new DateTime(1999, 2, 1);
            customers.Add(customer);

            customer = new CustomerModel();
            customer.Id = "02";
            customer.Name = "Teszt Elek";
            customer.BithDate = new DateTime(1980, 7, 11);
            customers.Add(customer);

            //Act
            printCustomers.Execute(customers);


        }
    }
}
