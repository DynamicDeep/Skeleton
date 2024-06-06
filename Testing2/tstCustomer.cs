
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Test to see that it exists
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            int testData = 1;
            // Assign the data to the property
            aCustomer.CustomerID = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerID, testData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            string testData = "adu rosa";
            // Assign the data to the property
            aCustomer.CustomerName = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerName, testData);
        }

        [TestMethod]
        public void EmailAddressOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            string testData = "john.doe@example.com";
            // Assign the data to the property
            aCustomer.EmailAddress = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.EmailAddress, testData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            string testData = "123456";
            // Assign the data to the property
            aCustomer.PhoneNumber = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.PhoneNumber, testData);
        }

        [TestMethod]
        public void RegistrationDateOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            DateTime testData = DateTime.Now;
            // Assign the data to the property
            aCustomer.RegistrationDate = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.RegistrationDate, testData);
        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            DateTime testData = DateTime.Now;
            // Assign the data to the property
            aCustomer.DateOfBirth = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateOfBirth, testData);
        }

        [TestMethod]
        public void GenderOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create some test data to assign to the property
            string testData = "Male";
            // Assign the data to the property
            aCustomer.Gender = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aCustomer.Gender, testData);
        }

        //****************************************FIND Method Test**************************************************************************
        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 CustomerID = 6;
            // Invoke the method
            Found = aCustomer.Find(CustomerID);
            // Check if the Find method returns true
            Assert.IsTrue(Found);
        }



        /********************************************PROPERTY DATA TESTS***********************************************************/

        
       

        [TestClass]
        public class clsCustomerTests
        {
            [TestMethod]
            public void FindMethodOK()
            {
                // Create an instance of the class we want to create
                clsCustomer aCustomer = new clsCustomer();
                // Create a Boolean variable to store the results of the validation
                Boolean Found = false;
                // Create some test data to use with the method
                Int32 CustomerID = 6;
                // Invoke the method
                Found = aCustomer.Find(CustomerID);
                // Check if the Find method returns true
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestCustomerIdFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.CustomerID != 6)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestCustomerNameFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.CustomerName != "Ruben")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestEmailAddressFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.EmailAddress != "Ruby3@hotmail.com")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestPhoneNumberFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.PhoneNumber != "675987")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestRegistrationDateFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.RegistrationDate != Convert.ToDateTime("2024-05-23"))
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestDateOfBirthFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.DateOfBirth != Convert.ToDateTime("1987-04-14"))
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestGenderFound()
            {
                clsCustomer aCustomer = new clsCustomer();
                Boolean Found = false;
                Boolean OK = true;
                Int32 CustomerID = 6;
                Found = aCustomer.Find(CustomerID);
                if (aCustomer.Gender != "Male")
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}