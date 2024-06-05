using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //****************************************************** VALIDATION FUNCTION ***********************************************************************************//
        // Good test data
        // Create some test data to pass to the method
        int PositionID = 1;
        string StaffName = "Will";
        string StaffEmail = "will@123.com";
        string StaffAddress = "Westminster";
        string StaffPhoneNumber = "123456";  // Converting it into String
        //****************************************************** Further Commands ***********************************************************************************//

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
            // Create an instance of the class we want to test 
            clsStaff AStaff = new clsStaff();

            // Create a Boolean variable to store the results of the validation 
            bool Found = false;

            // Create some test data to use with the method 
            int StaffId = 1;

            // Invoke the method 
            Found = AStaff.Find(StaffId);

            // Check if the Find method successfully found a staff member
            Assert.IsTrue(Found, "Find method failed to find staff with StaffId: " + StaffId);

            // Check if the staff name property is not null or empty
            Assert.IsFalse(string.IsNullOrWhiteSpace(AStaff.StaffName), "Staff name is null or empty");

            // Optionally, you can further validate the retrieved staff name against specific criteria
            // For example, checking if the name length is within a certain range
            Assert.IsTrue(AStaff.StaffName.Length >= 2 && AStaff.StaffName.Length <= 50, "Staff name length is not within the expected range");
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            int staffId = 1; // Set the staff ID for the test
                             // Setup any necessary test data or dependencies

            // Act
            bool result = staff.Find(staffId);

            // Assert
            Assert.IsTrue(result, "Staff email should be found");
            Assert.IsNotNull(staff.StaffEmail, "Staff email should not be null");
            // Add more assertions as needed to verify the retrieved email
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            // Arrange
            clsStaff staff = new clsStaff();
            int staffId = 1; // Set the staff ID for the test
                             // Setup any necessary test data or dependencies

            // Act
            bool result = staff.Find(staffId);

            // Assert
            Assert.IsTrue(result, "Staff address should be found");
            Assert.IsNotNull(staff.StaffAddress, "Staff address should not be null");
            // Add more assertions as needed to verify the retrieved address
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
            // Arrange: create an instance of the class and define valid input data
            clsStaff AStaff = new clsStaff();
            tstStaff testData = new tstStaff();  // Use test data from tstStaff class

            // Act: invoke the Valid method with test data
            string Error = AStaff.Valid(testData.PositionID, testData.StaffName, testData.StaffEmail, testData.StaffAddress, testData.StaffPhoneNumber);

            // Assert: check that the error message is empty, indicating valid inputs
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
            string StaffName = "a"; // This should not be ok (1 character)
                                    // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Name must be between 2 and 50 characters. ");
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
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
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
            string StaffEmail = "a@a.com"; // This should be ok
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
            string StaffEmail = "aa@a.com"; // This should be ok
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
            string StaffEmail = new string('a', 48) + "@a.com"; // This should be ok
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
            string StaffEmail = new string('a', 49) + "@a.com"; // This should be ok
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
            string StaffEmail = new string('a', 24) + "@a.com"; // This should be ok
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
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string StaffAddress = new string('a', 101); // This should fail (101 characters)

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
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "123456"; // This should be ok (6 digits)
                                                // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "12345"; // This should not be ok (less than 6 digits)
                                               // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Phone Number must contain exactly six digits. ");
        }


        [TestMethod]
        public void StaffPhoneNumberMax()
        {
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "1234567"; // This should not be ok (more than 6 digits)
                                                 // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Phone Number must contain exactly six digits. ");
        }
        [TestMethod]
        public void StaffPhoneNumberMid()
        {
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "12345a"; // This should not be ok (not all digits)
                                                // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Phone Number must contain exactly six digits. ");
        }


        [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "1234567"; // This should not be ok (more than 6 digits)
                                                 // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Phone Number must contain exactly six digits. ");
        }


        [TestMethod]
        public void StaffPhoneNumberExtremeMax()
        {
            // Create an instance of the class we want to test
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string StaffPhoneNumber = "123456789"; // This should not be ok (more than 6 digits)
                                                   // Invoke the method
            Error = AStaff.Valid(PositionID, StaffName, StaffEmail, StaffAddress, StaffPhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "Staff Phone Number must contain exactly six digits. ");
        }

    }
}
