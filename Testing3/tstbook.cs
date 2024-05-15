using ClassLibrary;
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
            clsGenre Genre = new clsGenre();
            Assert.IsNotNull(Genre);
        }
        [TestClass]
        public class tstGenre
        {
            public object Genre { get; private set; }

            [TestMethod]
            public void InstanceOk()
            {
                clsbook Book = new clsbook();
                Assert.IsNotNull(Book);
            }

          
            [TestMethod]
            public void TitlePropertyOk()
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
            public void PublicationYearPropertyOk()
            {
                clsbook Book = new clsbook();
                DateTime TestData = DateTime.Now.Date;
                Book.PublicationYear = TestData;
                Assert.AreEqual(Book.PublicationYear, TestData);

            }
            [TestMethod]
            public void PricePropertyOK()
            {
                clsbook Book = new clsbook();
                Decimal TestData = 0.99m;
                Book.Price = TestData;
                Assert.AreEqual(Book.Price, TestData);

            }
            [TestMethod]
            public void BookManagementPropertyoOK()
            {
                clsbook Book = new clsbook();
                Decimal TestData = 0.99m;
                Book.BookManagement = TestData;
                Assert.AreEqual(Book.BookManagement, TestData);

            }
            [TestMethod]
            public void ImagePathPropertyOK()
            {
                clsbook Book = new clsbook();
                string TestData = "/images/book1.jpg"; // Example image path
                Book.ImagePath = TestData;
                Assert.AreEqual(Book.ImagePath, TestData);

            }
            [TestMethod]
            public void GenreIdPropertyok()
            {
                clsGenre Genre = new clsGenre();
                Assert.IsNotNull(Genre);

            }
            [TestMethod]
            public void GenreIdPropertyOk()
            {
                clsGenre Genre = new clsGenre();
                int TestData = 0;
                Genre.Genre = TestData;
                Assert.AreEqual(Genre.Genre, TestData);

            }
         
            [TestMethod]
            public void BookIdforigianyOK()
            {
                clsGenre Book = new clsGenre();
                int TestData = 1;
               Book.BookId = TestData;
                Assert.AreEqual(Book.BookId, TestData);

            }


        }


    }
}
