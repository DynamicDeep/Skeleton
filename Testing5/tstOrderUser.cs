using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Testing5
{
    [TestClass]
    public class tstOrderUser
    {
        public int UserID { get; private set; }
        public clsOrderUser Password { get; private set; }
        public bool OK { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //test to see that is exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDProprtyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are tha same
            Assert.AreEqual(UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Deep";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "password1";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser, Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Order";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            Boolean Found = false;
            //create some test data to use with the method
            String UserName = "Deep";
            String Password = "password1";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestUserNamePWFoundOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Jagruti";
            string Password = "Password3";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user if property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct

        }

    }
}