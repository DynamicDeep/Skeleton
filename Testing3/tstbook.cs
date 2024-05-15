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
            public void DescriptionPropertyOK()
            {
                // Arrange
                clsbook Book = new clsbook();
                string TestData = "This is a test description.";

                // Act
                Book.Description = TestData;

                // Assert
                Assert.AreEqual(Book.Description, TestData);
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
           


        }


    }
}
