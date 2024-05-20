using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //test to see that is exists 
            Assert.IsNotNull(aSupplier);
        }

        public void SupplierId()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            int testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.SupplierId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierId, testData);
        }

        public void SupplierName()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "Name"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.SupplierName = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierName, testData);
        }

        public void ContactNo()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            Int32 testData = 1; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.ContactNo = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.ContactNo, testData);
        }

        public void SupplierAddress()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "123 Abbey lane, Leicester"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.SupplierAddress = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierAddress, testData);
        }

        public void SupplierEmailId()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "deep123@gmail.com"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.SupplierEmailId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierEmailId, testData);
        }
    }
}
