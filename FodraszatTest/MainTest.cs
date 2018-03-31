using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void RunTest()
        {
            var customerManager = new CustomerManager();
            var printCustomers = new PrintCustomers();
            //Arrange
            var main = new Main(customerManager, printCustomers);

            //Act
            main.Run();

            //Assert
            

        }
    }
}
