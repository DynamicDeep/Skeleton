using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {

        //good test data 
        //create some test data o pass the method 
        string Name = "Deep";
        string ContactNo = "123456789";
        string Address = "address";
        string EmailId = "deep123@gmail.com";
        string SupplierDate = DateTime.Now.ToShortDateString();
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //test to see that is exists 
            Assert.IsNotNull(aSupplier);
        }

        [TestMethod]
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

        [TestMethod]
        public void SupplierName()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "Name"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.Name = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Name, testData);
        }

        [TestMethod]
        public void ContactNumber()
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

        [TestMethod]
        public void SupplierAddress()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "123 Abbey lane, Leicester"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.Address = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Address, testData);
        }

        [TestMethod]
        public void SupplierEmailId()
        {
            // Create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            // Create some test data to assign to the property
            string testData = "deep123@gmail.com"; // Change this to whatever test data you want
            // Assign the data to the property
            aSupplier.EmailId = testData;
            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.EmailId, testData);
        }

        [TestMethod]
        public void FindMethodSupplierOk()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            Assert.IsTrue( Found );
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if(aSupplier.SupplierId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.Name != "Viki")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNoFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.ContactNo != 325435266)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.Address != "ghghjjjkkkukkkykuu")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailIdFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.EmailId != "jgkhklklllcuoi")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierDateFound()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
            Found = aSupplier.Find(SupplierId);
            if (aSupplier.SupplierDate != Convert.ToDateTime("22/03/2004"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        //-------------------------------------------Lab 10-----------------------------------------------------

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            string Error = "";
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            String Name = "";
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            String Name = "a";
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            String Name = "aa";
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(51, 'a');
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = aSupplier.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SupplierDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsSupplier aStock = new clsSupplier();
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
            Error = aStock.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            //test to see that the result is currect 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateMin()
        {
            //create an instance of the class we want to create 
            clsSupplier aStock = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            // set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString("dd-mm-yyyy");
            //invoke the method 
            Error = aStock.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSupplier aStock = new clsSupplier();
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
            Error = aStock.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsSupplier aStock = new clsSupplier();
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
            Error = aStock.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            //test to see that the result is currect 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateInvalidData()
        {
            //create an instance of the class we want to create 
            clsSupplier aStock = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method 
            Error = aStock.Valid(Name, ContactNo, Address, EmailId, SupplierDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }













    }
}
