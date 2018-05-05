using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    /// <summary>
    /// Summary description for SetPriceTest
    /// </summary>
    [TestClass]
    public class SetPriceTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            // Arrange
            var fileUtil = new FileUtil(); // TODO mockolni!!!
            var setPrice = new SetPrice(fileUtil);

            // Act
            setPrice.Execute(ServiceKey.BalayageMelir, 20001);
            setPrice.Execute(ServiceKey.Hajvagas, 10000);

            // Assert
            // TODO Mockolás után befejezni
        }

        [TestMethod]
        public void Execute_Invalid_Data()
        {
            // Arrange
            var fileUtil = new FileUtil(); // TODO úgy kell mockolni a Fileutilt, hogy a Balayage melírból kettő legyen
            var setPrice = new SetPrice(fileUtil);

            // Act
            setPrice.Execute(ServiceKey.BalayageMelir, 20001);

            // Assert
            // TODO Mockolás után befejezni
        }

    }
}
