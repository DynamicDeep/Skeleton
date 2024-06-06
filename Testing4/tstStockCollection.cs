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
            TestStock.StockName = "Maze Runner";
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
            TestItem.StockName = "Maze Runner";
           //add the item to the test list 
           TestList.Add(TestItem);
            //assign the data to the proprty
            AllStock.StockList = TestList;
            //test  to see that the two values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.BookId = 9;
            TestItem.Quantity = 1;
            TestItem.DateAdded = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TestItem.SupplierId = 1;
            TestItem.StockName = "Maze Runner";
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set ThisAddress to the test data 
            TestItem.stockId = PrimaryKey;
            //find the record 
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;
            TestItem.BookId = 9;
            TestItem.Quantity = 1;
            TestItem.DateAdded = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TestItem.SupplierId = 1;
            TestItem.StockName = "Maze Runner";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.stockId = PrimaryKey;
            TestItem.BookId = 10;
            TestItem.Quantity = 3;
            TestItem.DateAdded = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TestItem.SupplierId = 3;
            TestItem.StockName = "Alice In Wonderland";
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.stockId = 1;
            TestItem.BookId = 1;
            TestItem.Quantity = 1;
            TestItem.DateAdded = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TestItem.SupplierId = 1;
            TestItem.StockName = "Maze Runner";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.stockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStockNameMethodOk()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection allStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByStockName("");
            //test to see that the two values are the same
            Assert.AreEqual(allStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByStockNameNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a stock name that doesn't exist
            FilteredStock.ReportByStockName("Bape Hoodie");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }







    }
}
