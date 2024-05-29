using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        private object ACustomer;

        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it excists
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer(1);
            //Create some test data to assign to the property
            int testData = 1;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerID, testData);
        }
        [TestMethod]
        public void CustomernameIDOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //Create some test data to assingn to the property
            string testData = "adu rosa";
            //Assign the daata to the property
            aCustomer.CustomerName = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerName, testData);
        }
        [TestMethod]
        public void EmailAddressIDOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //Create some test data to assingn to the property
            string testData = "@";
            //Assign the daata to the property
            aCustomer.EmailAddress = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.EmailAddress, testData);
        }

        [TestMethod]
        public void PhonenumberIDOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //Create some test data to assingn to the property
            int testData = 1;
            //Assign the daata to the property
            aCustomer.phoneNumber = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.phoneNumber, testData);
        }
        [TestMethod]
        public void registrationIDOK()
        {
            //Create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //Create some test data to assign to the property
            DateTime testData = DateTime.Now;
            //Assign the data to the property
            aCustomer.registration = testData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.registration, testData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            // Create an instance of the class we want to test
            clsCustomer aCustomer = new clsCustomer();

            // Create some test data to assign to the property
            DateTime testData = DateTime.Now;

            // Assign the data to the property
            aCustomer.CustomerDateOfBirth = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(aCustomer.CustomerDateOfBirth, testData);
        }
        [TestMethod]
        public void GenderPropertyOk()
        {
            // Create an instance of the class we want to test
            clsCustomer aCustomer = new clsCustomer();

            // Create some test data to assign to the property
            string testData = "Male"; // For example, a gender

            // Assign the data to the property
            aCustomer.Gender = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(aCustomer.Gender, testData);
        }
    }


    //****************************************FIND METOD***************************************************************************


    namespace Testing2
    {
        [TestClass]
        public class tstCustomer
        {
            private clsCustomer _customer;
            private string booltestGender;

            public object Gender { get; private set; }

            [TestInitialize]
            public void Setup()
            {
                _customer = new clsCustomer(21);
            }

            [TestMethod]
            public void InstanceOK()
            {
                Assert.IsNotNull(_customer);
            }

            [TestMethod]
            public void CustomerIdPropertyOK()
            {
                Assert.AreEqual(21, _customer.CustomerID);
            }

            [TestMethod]
            public void CustomerNamePropertyOK()
            {
                string testName = "John Doe";
                _customer.CustomerName = testName;
                Assert.AreEqual(testName, _customer.CustomerName);
            }

            [TestMethod]
            public void EmailAddressPropertyOK()
            {
                string testEmail = "john.doe@example.com";
                _customer.CustomerEmail = testEmail;
                Assert.AreEqual(testEmail, _customer.CustomerEmail);
            }

            [TestMethod]
            public void PhoneNumberPropertyOK()
            {
                string testPhone = "1234567890";
                _customer.CustomerPhone = testPhone;
                Assert.AreEqual(testPhone, _customer.CustomerPhone);
            }

            [TestMethod]
            public void DateOfBirthPropertyOK()
            {
                DateTime testDate = new DateTime(1980, 1, 1);
                _customer.CustomerDateOfBirth = testDate;
                Assert.AreEqual(testDate, _customer.CustomerDateOfBirth);
            }
            [TestMethod]
            public void GenderPropertyOK()
            {
                String testGender = "Male";
                _customer.CustomerGender = testGender;
                Assert.AreEqual(testGender, _customer.CustomerGender);
            }


            [TestMethod]
            public void RegistrationDatePropertyOK()
            {
                DateTime testDate = DateTime.Now.Date;
                _customer.DateOfSubscription = testDate;
                Assert.AreEqual(testDate, _customer.DateOfSubscription);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                clsCustomer customer = new clsCustomer(21);
                bool found = customer.Find(21);
                Assert.IsTrue(found);
            }
        }
    }
}
