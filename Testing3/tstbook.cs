using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstbook
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsbook Book = new clsbook();
            Assert.IsNotNull(Book);
        }
    }
}
