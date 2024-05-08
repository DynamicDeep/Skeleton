using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //test to see that is exists 
            Assert.IsNotNull(aSupplier);
        }
    }
}
