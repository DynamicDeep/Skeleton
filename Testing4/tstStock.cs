﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsStock aStock = new clsStock();
            //test to see that it exits
            Assert.IsNotNull(aStock);
        }
    }
}
