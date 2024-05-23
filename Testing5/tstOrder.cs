using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exits
            Assert.IsNotNull(AnOrder);
        }

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

    }
        

    }
