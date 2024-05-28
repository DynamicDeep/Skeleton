using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        public void StaffIDOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            int testData = 1;
            AStaff.StaffId = testData;
            Assert.AreEqual(AStaff.StaffId, testData);
        }
        public void StaffNameOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffName";
            AStaff.StaffName = testData;
            Assert.AreEqual(AStaff.StaffName, testData);
        }
        public void StaffAddressOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffAddress";
            AStaff.StaffAddress = testData;
            Assert.AreEqual(AStaff.StaffAddress, testData);
        }
        public void StaffEmailOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffEmail";
            AStaff.StaffEmail = testData;
            Assert.AreEqual(AStaff.StaffEmail, testData);
        }
        public void StaffPhoneNumberOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            int testData = 1;
            AStaff.StaffPhoneNumber = testData;
            Assert.AreEqual(AStaff.StaffPhoneNumber, testData);
        }
        public void PositionIDOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            int testData = 1;
            AStaff.PositionId = testData;
            Assert.AreEqual(AStaff.PositionId, testData);
        }
        //-------------------------------------------------LAB 9---------------------------------------------------------------//
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 1;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the whether the results is true
            Assert.IsTrue(Found);
        }
        public void TestStaffIdFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Id
            if (AStaff.StaffId != 1)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        public void TestStaffNameFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Name
            if (AStaff.StaffName != "Will")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        public void TestStaffEmailFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Email
            if (AStaff.StaffEmail != "will@123.com")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        public void TestStaffAddressFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Address
            if (AStaff.StaffEmail != "Westminister")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        public void TestStaffPhoneNumberFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Phone Number
            if (AStaff.StaffPhoneNumber != 123456)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
        public void TestStaffPositionFound()
        {
            //create am instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation 
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AStaff.Find(StaffId);
            //check the Staff Position
            if (AStaff.PositionId != 1)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }
    }
}
