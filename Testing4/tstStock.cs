using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //test to see that it exits
            Assert.IsNotNull(aStock);
        }


        public void QuantityOK()
        {
            // Create an instance of the class we want to create
            clsStock aStock = new clsStock();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aStock.Quantity = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.Quantity, testData);
        }

        public void DateAddedPropertyOK()
        {
            //create an instance of the class we wanta to create
            clsStock aStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStock.DateAdded = TestData;
            //Test to see that two values are the same 
            Assert.AreEqual(aStock.DateAdded, TestData);
        }

        public void StockIdOK()
        {
            // Create an instance of the class we want to create
            clsStock aStock = new clsStock();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aStock.StockId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.StockId, testData);
        }

        public void SuppierIdOK()
        {
            // Create an instance of the class we want to create
            clsStock aStock = new clsStock();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aStock.SupplierId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.SupplierId, testData);
        }

        public void BookIdOK()
        {
            //Create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //Create some test data to assign to the property
            Int32 testData = 1;
            //Assign the data to the property
            aStock.BookId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.bookId, testData);

        }




    }
}
