using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case, the data needs to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the data 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Will";
            TestItem.StaffEmail = "will@123.com";
            TestItem.StaffAddress = "Westminister";
            TestItem.StaffPhoneNumber = "123456";
            TestItem.PositionID = 1;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            int SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void StaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.StaffName = "Will";
            TestStaff.StaffEmail = "will@123.com";
            TestStaff.StaffAddress = "Westminister";
            TestStaff.StaffPhoneNumber = "123456";
            TestStaff.PositionID = 1;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to property
            //in this case, the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of the data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "Will";
            TestItem.StaffEmail = "will@123.com";
            TestItem.StaffAddress = "Westminister";
            TestItem.StaffPhoneNumber = "123456";
            TestItem.PositionID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            // Create an instance of the class we want to test
            clsStaffCollection AllStaff = new clsStaffCollection();

            // Add two records to the StaffList
            AllStaff.StaffList.Add(new clsStaff());
            AllStaff.StaffList.Add(new clsStaff());

            // Test to see that the Count property equals 2
            Assert.AreEqual(AllStaff.Count, 2);
        }

    }
}
