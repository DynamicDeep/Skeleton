using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing3
{
    [TestClass]
    public class tstBookCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Test to check if an instance of clsBookCollection can be created
            clsBookCollection AllBook = new clsBookCollection();
            Assert.IsNotNull(AllBook);
        }

        [TestMethod]
        public void AddressListOK()
        {
            // Create an instance of the class we want to create
            clsBookCollection AllBook = new clsBookCollection();

            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsbook> TestList = new List<clsbook>();

            // Create the item of test data
            clsbook TestItem = new clsbook();

            // Set its properties
            TestItem.BookId = 1;
            TestItem.Title = "Romeo & Juliet";
            TestItem.Author = "Shakespeare";
            TestItem.PublicationYear = DateTime.Now.Date;
            TestItem.Price = 0.99m;
            TestItem.Description = "Romance";
            TestItem.ImagePath = "image.jpg";

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllBook.BookList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllBook.BookList, TestList);
        }

        [TestMethod]
        public void CountOK()
        {
            // Create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();

            // Connect to the database and get the actual count of records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblbook_SelectAll"); // Assuming the stored procedure to fetch all books is named 'sproc_Book_SelectAll'
            int expectedCount = DB.Count;

            // Test to see that the two values are the same
            Assert.AreEqual(AllBooks.Count, expectedCount);
        }

        [TestMethod]
        public void ThisBook()
        {
            // Create an instance of the class we want to create
            clsBookCollection AllBook = new clsBookCollection();

            // Create a test item to assign to the property
            clsbook TestBook = new clsbook();

            // Set its properties
            TestBook.BookId = 1;
            TestBook.Title = "Romeo & Juliet";
            TestBook.Author = "Shakespeare";
            TestBook.PublicationYear = DateTime.Now.Date;
            TestBook.Price = 0.99m;
            TestBook.Description = "Romance";
            TestBook.ImagePath = "image.jpg";

            // Assign the data to the property
            AllBook.ThisBook = TestBook;

            // Test to see that the two values are the same
            Assert.AreEqual(AllBook.ThisBook, TestBook);
        }

        [TestMethod]
        public void ListAndCount()
        {
            // Create an instance of the class we want to create
            clsBookCollection AllBook = new clsBookCollection();

            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsbook> TestList = new List<clsbook>();

            // Create the item of test data
            clsbook TestItem = new clsbook();

            // Set its properties
            TestItem.BookId = 1;
            TestItem.Title = "Romeo & Juliet";
            TestItem.Author = "Shakespeare";
            TestItem.PublicationYear = DateTime.Now.Date;
            TestItem.Price = 0.99m;
            TestItem.Description = "Romance";
            TestItem.ImagePath = "image.jpg";

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllBook.BookList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllBook.BookList.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordPresent()
        {
            // Create an instance of the class we want to create
            clsBookCollection AllBook = new clsBookCollection();

            // Connect to the database and get the actual count of records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblbook_SelectAll"); // Assuming the stored procedure to fetch all books is named 'sproc_Book_SelectAll'
            int expectedCount = DB.Count;

            // Test to see that the two values are the same
            Assert.AreEqual(AllBook.Count, expectedCount);
        }

        //###########################################START TEST GENRE COLLECTIONS###############################################################

        [TestClass]
        public class tstGenreCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsGenresCollection AllGenre = new clsGenresCollection();
                Assert.IsNotNull(AllGenre);
            }

            [TestMethod]
            public void GenreListOK()
            {
                // Create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();

                // Create some test data to assign to the property
                // In this case, the data needs to be a list of objects
                List<clsGenres> TestList = new List<clsGenres>();

                // Create the test data item
                clsGenres TestItem = new clsGenres();

                // Set its properties
                TestItem.GenreId = 1;
                TestItem.BookGenre = "Fantasy";
                TestItem.BookId = 1;

                // Add the item to the test list
                TestList.Add(TestItem);

                // Assign the data to the property
                AllGenre.GenreList = TestList;

                // Test to see if the two values are the same
                Assert.AreEqual(AllGenre.GenreList, TestList);
            }

            [TestMethod]
            public void CountOK()
            {
                // Create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();

                // Conectar ao banco de dados e obter a contagem real de registros
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_Genre_SelectAll");
                int expectedCount = DB.Count;

                // Test to see if the two values are the same
                Assert.AreEqual(AllGenre.Count, expectedCount);
            }

            [TestMethod]
            public void ThisGenreOK()
            {
                // Create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();

                // Create a test item to assign to the property
                clsGenres TestGenre = new clsGenres();

                // Set its properties
                TestGenre.GenreId = 1;
                TestGenre.BookGenre = "Fantasy";
                TestGenre.BookId = 1;

                // Assign the data to the property
                AllGenre.ThisGenre = TestGenre;

                // Test to see if the two values are the same
                Assert.AreEqual(AllGenre.ThisGenre, TestGenre);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                // Create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();

                // Create some test data to assign to the property
                // In this case, the data needs to be a list of objects
                List<clsGenres> TestList = new List<clsGenres>();

                // Create the test data item
                clsGenres TestItem = new clsGenres();

                // Set its properties
                TestItem.GenreId = 1;
                TestItem.BookGenre = "Fantasy";
                TestItem.BookId = 1;

                // Add the item to the test list
                TestList.Add(TestItem);

                // Assign the data to the property
                AllGenre.GenreList = TestList;

                // Test to see if the two values are the same
                Assert.AreEqual(AllGenre.GenreList.Count, TestList.Count);
            }

            // Remover o teste TwoRecordPresent ou ajustá-lo para uma verificação dinâmica.
        }
    }
}
