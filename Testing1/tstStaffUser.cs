using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AUser = new clsStaffUser();
            Assert.IsNotNull(AUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStaffUser AUser = new clsStaffUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser AUser = new clsStaffUser();
            string TestData = "Shaurya";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser AUser = new clsStaffUser();
            string TestData = "password";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser AUser = new clsStaffUser();
            string TestData = "Staff";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethod()
        {
            clsStaffUser AUser = new clsStaffUser();
            Boolean Found = false;
            string UserName = "Shaurya";
            string Password = "password";
            Found = AUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStaffUser AUser = new clsStaffUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Shaurya";
            string Password = "password";
            Found = AUser.FindUser(UserName, Password);
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
