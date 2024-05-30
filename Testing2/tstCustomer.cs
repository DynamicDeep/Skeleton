using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        private object ACustomer;

        public object AnCustomer { get; private set; }

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
        //****************************************FIND Method Test**************************************************************************

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = aCustomer.Find(CustomerID);
            // Check if the Find method returns true
            Assert.IsTrue(Found);
        }


    

    /********************************************PROPERTY DATA TESTS***********************************************************/
    [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustumerID = 1;
            //invoke the method
            Found = aCustomer.Find(CustumerID);
            //check the address id property
            if (aCustomer.CustomerId != 1)
            {
            }
            else
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the customer name property
            if (aCustomer.CustomerName != "John Doe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]



        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the email address property
            if (AnCustomer.EmailAddress != "john.doe@example.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the phone number property
            if (ACustomer.PhoneNumber != "1234567890")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestRegistrationDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the registration date property
            if (aCustomer.RegistrationDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the date of birth property
            if (aCustomer.DateOfBirth != Convert.ToDateTime("01/01/1980"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 21; // Match this with the hardcoded value in the Find method
                                   //invoke the method
            Found = aCustomer.Find(CustomerId);
            //check the gender property
            if (aCustomer.Gender != "Male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}




