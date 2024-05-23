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

        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void StockIdOK()
        {
            // Create an instance of the class we want to create
            clsStock aStock = new clsStock();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aStock.stockId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.stockId, testData);
        }
        [TestMethod]
        public void SuppierIdOK()
        {
            // Create an instance of the class we want to create
            clsStock aStock = new clsStock();
            // Create some test data to assign to the property
            Int32 testData = 1;
            // Assign the data to the property
            aStock.SupplierId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.SupplierId, testData);
        }
        [TestMethod]
        public void BookIdOK()
        {
            //Create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //Create some test data to assign to the property
            int testData = 1;
            //Assign the data to the property
            aStock.BookId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aStock.BookId, testData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StockId = 3;
            //invoke the method 
            Found = aStock.Find(StockId);
            //test to see if the results is true
            Assert.IsTrue( Found );
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            //create am instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 stockId = 3;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.stockId != 3)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            //create am instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 stockId = 3;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.BookId != 3)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create am instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 stockId = 3;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.SupplierId != 3)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create am instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 stockId = 3;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.DateAdded != Convert.ToDateTime("05/04/2023"))
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create am instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 stockId = 3;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.Quantity != 6)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }














    }
}
