using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //******************************************************VALIDATION FUNCTION***********************************************************************************//
        //good test data 
        //create some test data to pass the method 
        int PositionID = 1;
        string StaffName = "Will";
        string StaffEmail = "will@123.com";
        string StaffAddress = "Westminister";
        string StaffPhoneNumber = "123456"; //convert to string
       
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffIDOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            int testData = 1;
            AStaff.StaffId = testData;
            Assert.AreEqual(AStaff.StaffId, testData);
        }
        [TestMethod]
        public void StaffNameOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffName";
            AStaff.StaffName = testData;
            Assert.AreEqual(AStaff.StaffName, testData);
        }
        [TestMethod]
        public void StaffAddressOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffAddress";
            AStaff.StaffAddress = testData;
            Assert.AreEqual(AStaff.StaffAddress, testData);
        }
        [TestMethod]
        public void StaffEmailOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            string testData = "StaffEmail";
            AStaff.StaffEmail = testData;
            Assert.AreEqual(AStaff.StaffEmail, testData);
        }
        [TestMethod]
        public void StaffPhoneNumberOK()
        {
            // Create an instance class
            clsStaff AStaff = new clsStaff();
            // Create test data
            int testData = 1;
            AStaff.StaffPhoneNumber = testData;
            Assert.AreEqual(AStaff.StaffPhoneNumber, testData);
        }
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        //******************************************************  Lab10  ***********************************************************************************//
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffPhoneNumber);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        //------------------------------------------------ PositionID Tests ----------------------------------------------------------//

        [TestMethod]
        public void PositionIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //String c=variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 0; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMin()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 1; //this should be ok 
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 2; //this should be ok 
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 9; //this should be ok 
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMax()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 10; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMid()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 5; //this should be ok
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 11; //this should ok
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionIDExtremeMax()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            int PositionID = 500;
            // BookId = Convert.ToInt32(BookId.ToString().PadRight(500));
            //invoke the method 
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }
        //------------------------------------------------ StaffName Tests ----------------------------------------------------------//
        [TestMethod]
        public void StaffNameMin()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = "a"; // This should be ok (1 character)
                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = "aa"; // This should be ok (2 characters)
                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = new string('a', 49); // This should be ok (49 characters)
                                                // Invoke the method
            Error = AStaff.Valid(PositionI, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = new string('a', 50); // This should be ok (50 characters)
                                                // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = new string('a', 51); // This should fail (51 characters)
                                                // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void StaffNameMid()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffName = new string('a', 25); // This should be ok (25 characters)
                                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //------------------------------------------------ StaffEmail Tests ----------------------------------------------------------//
        [TestMethod]
        public void StaffEmailMin()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = "a"; // This should be ok (1 character)
                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = "aa"; // This should be ok (2 characters)
                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = new string('a', 49); // This should be ok (49 characters)
                                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = new string('a', 50); // This should be ok (50 characters)
                                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = new string('a', 51); // This should fail (51 characters)
                                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffEmail = new string('a', 25); // This should be ok (25 characters)
                                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //________________________________________________ Staff Address ________________________________________________________//
        [TestMethod]
        public void StaffAddressMin()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = "a"; // This should be ok (1 character)
                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = "aa"; // This should be ok (2 characters)
                                      // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = new string('a', 49); // This should be ok (49 characters)
                                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = new string('a', 50); // This should be ok (50 characters)
                                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = new string('a', 51); // This should fail (51 characters)
                                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string StaffAddress = new string('a', 25); // This should be ok (25 characters)
                                                     // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //________________________________________________ Staff PhoneNumber ________________________________________________________//
        [TestMethod]
        public void StaffPhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffPhoneNumber = 0; // this should fail
                                      //invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffPhoneNumber = 999999; //this should be ok
                                           //invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffPhoneNumber = 9999999999; //this should be ok
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffPhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int StaffPhoneNumber = 5555555555;
            //invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            long StaffPhoneNumber = 10000000000; // this should fail
                                                 //invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            long StaffPhoneNumber = 999999999999999; // this should fail
                                                     //invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
