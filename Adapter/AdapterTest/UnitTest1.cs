using System;
using Adapter.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Product()
        {
            //Arrange
            string expectedProductTitle= "Product";
            string expectedProductBarCode = "####";
            decimal expectedProductUnitPrice = 2233;
       
            //Act
            Product product = new Product();
       
            //Assert

            Assert.AreEqual(expectedProductTitle,product.Title);
            Assert.AreEqual(expectedProductBarCode, product.BarCode);
            Assert.AreEqual(expectedProductUnitPrice, product.UnitPrice);
        }

        [TestMethod]
        public void Test_SomeExternalVendorProduct()
        {
        }
    }
}
