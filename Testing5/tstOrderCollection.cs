using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstOrderCollection
    {
        public object MThisOrder { get; private set; }
        public object MThisDeliveryDate { get; private set; }

        [TestMethod]
        public void InstancesOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 101;
            TestItem.Address = "1 Leicester Road";
            TestItem.TotalCost = 10;
            TestItem.DeliveryDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }

        [TestMethod]
        public void OrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Active = true;
            TestOrder.OrderId = 1;
            TestOrder.TotalCost = 10;
            TestOrder.CustomerId = 101;
            TestOrder.Address = "1 Leicester Road";
            TestOrder.DeliveryDate = DateTime.Now;
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of the data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderId = 101;
            TestItem.TotalCost = 10;
            TestItem.CustomerId = 101;
            TestItem.DeliveryDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            int SomeCount = 22;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its propertises
            TestItem.OrderId = 1;
            TestItem.CustomerId = 4;
            TestItem.TotalCost = 1;
            TestItem.Address = "5";
            TestItem.DeliveryDate = DateTime.Now;
            //set Thisaddress to the test data
            AllOrder.ThisOrder = TestItem;
            //add the records
            PrimaryKey = AllOrder.Add();
            //find the record
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);


        }
        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            // create the item of the data
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 101;
            TestItem.TotalCost = 1;
            TestItem.Address = "7";
            TestItem.DeliveryDate = DateTime.Now;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test record
            TestItem.OrderId = 1;
            TestItem.CustomerId = 102;
            TestItem.TotalCost = 11;
            TestItem.Address = "5";
            TestItem.DeliveryDate = DateTime.Now.AddDays(-100);
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            // create the item of the data
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 101;
            TestItem.TotalCost = 1;
            TestItem.Address = "7";
            //set ThisOrder to the test data
            TestItem.DeliveryDate = DateTime.Now;
            AllOrder.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]

        public void ReportByAddessOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllAddress = new clsOrderCollection();
            //create an intance of the filtered data
            clsOrderCollection filteredAddress = new clsOrderCollection();
            //apply a blank string (should retrun all record);
            filteredAddress.ReportByAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAddress.Count, filteredAddress.Count);

        }

        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            //create an instance of the class we want to create
            clsOrderCollection FilteredAddress = new clsOrderCollection();
            //apply a post code that doesnt exist
            FilteredAddress.ReportByAddress("xxx xxx");
            Assert.AreEqual(0, FilteredAddress.Count);
        }

        [TestMethod]
        public void ReportByTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //variable to store the outocome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredOrder.ReportByAddress("yyy yyy");
            //check that the correct number of records are found
            if (FilteredOrder.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredOrder.OrderList[0].Orderid != 35)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredOrder.OrderList[1].Orderid != 36)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}






