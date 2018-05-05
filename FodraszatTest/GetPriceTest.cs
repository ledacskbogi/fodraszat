using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    /// <summary>
    /// Summary description for GetPriceTest
    /// </summary>
    [TestClass]
    public class GetPriceTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            //Arrange
            var getPrice = new GetPrice();

            //Act
            var result = getPrice.Execute(ServiceKey.Hajvagas);

            //Assert
            Assert.AreEqual(10000, result);

        }


    }
}
