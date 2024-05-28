using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create am instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the data 
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its item of test data
            TestItem.stockId = 1;
            TestItem.BookId = 1;
            TestItem.Quantity = 2;
            TestItem.DateAdded = Convert.ToDateTime("12/05/2004"); 
            TestItem.SupplierId = 4;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);
        }

      

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.stockId = 1;
            TestStock.BookId = 1;
            TestStock.Quantity = 2;
            TestStock.DateAdded = Convert.ToDateTime("12/05/2004");
            TestStock.SupplierId = 1;
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]    
        public void ListAndCount()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objcects 
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List 
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set the properties of the test object
            TestItem.stockId = 1;
            TestItem.BookId = 1;
            TestItem.Quantity = 2;
            TestItem.DateAdded = Convert.ToDateTime("12/05/2004");
            TestItem.SupplierId = 1;
           //add the item to the test list 
           TestList.Add(TestItem);
            //assign the data to the proprty
            AllStock.StockList = TestList;
            //test  to see that the two values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

      

    }
}
