using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    [TestClass]
    public class GetCustomersTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            //Arrange
            var customerManager = new CustomerManager();

            //Act
            var result = customerManager.GetAll();

            //Assert
            Assert.AreEqual(3, result.Count);

        }
    }
}
