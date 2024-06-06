using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string CustomerId = "2";
        string TotalCost = "10.00";
        string Address = "1 leicester Road";
        string DeliveryDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void OrderIdOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int testData = 1;
            AnOrder.OrderId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, testData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want

            AnOrder.CustomerId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, testData);
        }

        [TestMethod]
        public void TotalCostOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            double testData = 1.99; // Change this to whatever test data you want
                                    // Assign the data to the property
            AnOrder.TotalCost = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalCost, testData);
        }

        [TestMethod]
        public void AddressOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Create some test data to assign to the property
            String testData = "1 Leiecter Road"; // Change this to whatever test data you want
                                                 // Assign the data to the property
            AnOrder.Address = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Address, testData);
        }

        [TestMethod]
        public void DeliveryDateOK()
        {
            //create an instance of the class we wanta to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DeliveryDate = TestData;
            //Test to see that two values are the same 
            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }

        ////////////////// found Method Test//////////////////////////////////////
        [TestMethod]
        public void DeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it it)
            Boolean Ok = true;
            //create some test data to use with the method
            int OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the dataAdded property
            if (AnOrder.DeliveryDate != Convert.ToDateTime("01/01/2024"))
            {
                Ok = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidCustomerId()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomerId = "2"; //this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        
        [TestMethod]
        public void TotalCostMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "0"; // this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "17"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "18"; //this should be ok
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TotalCostMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "10";
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMaxPlusOn()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "19"; // this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string TotalCost = "";
            TotalCost = TotalCost.PadRight(50, 'a');
                           //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "" ; // this should fail
                                  //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = ""; //this should be ok
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should be ok
            Address = Address.PadRight(50, 'a');
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOn()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "7"; // this should fail
                                  //invoke the method
            Address = Address.PadRight(51, 'a');
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "";
            TotalCost = TotalCost.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); ;
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryDateMixLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        
        [TestMethod]
        public void DeliveryDateMixPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDatesExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is les 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is les 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerId, TotalCost, Address, DeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}