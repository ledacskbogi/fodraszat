using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;

namespace FodraszatTest
{
    /// <summary>
    /// Summary description for FileUtilTest
    /// </summary>
    [TestClass]
    public class FileUtilTest
    {
        [TestMethod]
        public void WriteAllText()
        {
            // Arrange
            var fileUtil = new FileUtil();

            // Act
            fileUtil.WriteAllText("D:\\aaaaaa\\Fodraszat\\FodraszatTest\\TestData\\testfile.txt", "\"Hello World!\" írta Bogi");

            // Assert

        }

        [TestMethod]
        public void ReadAllText()
        {
            // Arrange
            var fileUtil = new FileUtil();

            // Act
            var text = fileUtil.ReadAllText("D:\\aaaaaa\\Fodraszat\\FodraszatTest\\TestData\\testfile.txt");

            // Assert
            Assert.AreEqual("\"Hello World!\" írta Bogi", text);
        }

        [TestMethod]
        public void ReadAllText_FileNotExists()
        {
            // Arrange
            var fileUtil = new FileUtil();

            // Act
            var text = fileUtil.ReadAllText("D:\\aaaaaa\\Fodraszat\\FodraszatTest\\TestData\\testfile0.txt");

            // Assert
            Assert.AreEqual(string.Empty, text);
        }
    }
}
