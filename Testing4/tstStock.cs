using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {

        //good test data 
        //create some test data to pass the method 
        int BookId = 1;
        int Quantity = 1;
        String DateAdded = DateTime.Now.ToShortDateString();
        int SupplierId = 1;


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
            Assert.IsTrue(Found);
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

        [TestMethod]

        //-------------------------------------------------LAB 10---------------------------------------------------------------//

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        //------------------------------------------------BookId Tests----------------------------------------------------------//

        [TestMethod]
        public void BookIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //String c=variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 0; //this should be ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMin()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 1; //this should be ok 
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 2; //this should be ok 
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 9; //this should be ok 
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMax()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 10; //this should be ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMid()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 5; //this should be ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 11; //this should ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookIdExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int BookId = 500;
            // BookId = Convert.ToInt32(BookId.ToString().PadRight(500));
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        //---------------------------------------------DateAdded Test----------------------------------------------------------//


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString("dd-mm-yyyy");
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        //-------------------------------------------------------------------Quantity test-------------------------------------------------------------------------------------//

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a min Less One value
            int Quantity = 0;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a min value
            int Quantity = 1;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a min + 1 value
            int Quantity = 2;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a max - 1 value
            int Quantity = 99;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a max value
            int Quantity = 100;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a max + 1 value
            int Quantity = 101;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a mid value
            int Quantity = 50;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the Quantity to a extreme max value
            int Quantity = 500;
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
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































    }
}
