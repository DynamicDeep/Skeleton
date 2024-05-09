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
        [TestMethod]
        public void TitlePropertyOKk()
        {
            clsbook Book = new clsbook();
            string TestData = "Romeu";
            Book.Title = TestData;
            
            
            Assert.AreEqual(Book.Title, TestData);

        }
        [TestMethod]
        public void AuthorPropertyOK()
        {
            clsbook Book = new clsbook();
            string TestData = "Shakespeare";
            Book.Author = TestData;
            Assert.AreEqual(Book.Author, TestData);
      
        }
        [TestMethod]
        public void PublicationyearOK()
        {
            clsbook Book = new clsbook();
            DateTime TestData = DateTime.Now.Date;
            Book.PublicationDate = TestData;
            Assert.AreEqual(Book.PublicationDate, TestData);

        }
        [TestMethod]
        public void PriceOK()
        {
            clsbook Book = new clsbook();
            Decimal TestData = 0.99m;
            Book.Price = TestData;
            Assert.AreEqual(Book.Price, TestData);

        }
    }
}
