using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Diagnostics;

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
        string StockName = "Maze Runner";


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
        public void StockNameOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string testData = "Maze Runner";
            //assign the data to the property
            anStock.StockName = testData;
            //test to see that the two values are the same
            Assert.AreEqual(anStock.StockName, testData);
        }

        //--------------------------------------------------lab 9----------------------------------------------------------------------
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StockId = 1;
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
            Int32 stockId = 1;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.stockId != 1)
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
            Int32 stockId = 1;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.BookId != 1)
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
            Int32 stockId = 1;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.SupplierId != 1)
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
            Int32 stockId = 1;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.DateAdded != Convert.ToDateTime("12/05/2004"))
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
            Int32 stockId = 1;
            //invoke the method 
            Found = aStock.Find(stockId);
            //check the Stock Id
            if (aStock.Quantity != 2)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNameFound() 
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            Boolean OK = true;
            Int32 stockId = 1;
            Found = anStock.Find(stockId);
            if(anStock.StockName !="Maze Runner")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //-------------------------------------------------LAB 10---------------------------------------------------------------//

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            int BookId = 1000000; //this should be ok 
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            int BookId = 1000001; //this should be ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            int BookId = 500000; //this should be ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded,StockName);
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
            int BookId = 1000002; //this should ok
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            int BookId = 100000000;
            // BookId = Convert.ToInt32(BookId.ToString().PadRight(500));
            //invoke the method 
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        //---------------------------------------------DateAdded Test----------------------------------------------------------//


       

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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded,StockName);
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
            Error = aStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = ""; //min -1 0 characters
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "a"; //min 1 character
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "aa"; //min +1 2 characters
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //max -1 49 characters
            StockName = StockName.PadRight(49, 'a');
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //max 50 characters
            StockName = StockName.PadRight(50, 'a');
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockNameMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //mid 25 characters
            StockName = StockName.PadRight(25, 'a');
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //max +1 51 characters
            StockName = StockName.PadRight(51, 'a');
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //extreme max 500 characters
            StockName = StockName.PadRight(500, 'a');
            //invoke the method
            Error = anStock.Valid(BookId, Quantity, DateAdded, StockName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StatStatisticsGroupedByBookID()
        {
            clsStock anStock = new clsStock();
            DataTable dT = anStock.StatisticsGroupedByBookID();
            int noOfRecord = 6;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedBySupplierID()
        {
            clsStock anStock = new clsStock();
            DataTable dT = anStock.StatisticsGroupedBySupplierID();
            int noOfRecord = 4;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }
}
