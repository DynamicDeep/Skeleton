using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstOrderCollection
    {
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
            int SomeCount = 5;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
    }
}
    

