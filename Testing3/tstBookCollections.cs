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
        //##############################################ADD METHOD, UPDATE METHOD AND DELITE METOD FOR BOOK ###########################################################################
        //ADD METOD
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            // create the item of test data
            clsbook TestItem = new clsbook();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Title = "New Book";
            TestItem.Author = "Author Name";
            TestItem.PublicationYear = DateTime.Now.Date;
            TestItem.Price = 12.99m;
            TestItem.Description = "Test Description";
            TestItem.ImagePath = "test.jpg";
            // set ThisBook to the test data
            AllBooks.ThisBook = TestItem;
            // add the record
            PrimaryKey = AllBooks.Add();
            // set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            // find the record
            bool Found = AllBooks.ThisBook.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }
        //Update
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            // create the item of test data
            clsbook TestItem = new clsbook();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Title = "Original Title";
            TestItem.Author = "Original Author";
            TestItem.PublicationYear = DateTime.Now.Date;
            TestItem.Price = 10.99m;
            TestItem.Description = "Original Description";
            TestItem.ImagePath = "original.jpg";
            // set ThisBook to the test data
            AllBooks.ThisBook = TestItem;
            // add the record
            PrimaryKey = AllBooks.Add();
            // set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            // modify the test data
            TestItem.Title = "Updated Title";
            TestItem.Author = "Updated Author";
            TestItem.PublicationYear = DateTime.Now.Date.AddYears(-1);
            TestItem.Price = 15.99m;
            TestItem.Description = "Updated Description";
            TestItem.ImagePath = "updated.jpg";
            // set ThisBook to the updated test data
            AllBooks.ThisBook = TestItem;
            // update the record
            AllBooks.Update();
            // find the record
            bool Found = AllBooks.ThisBook.Find(PrimaryKey);
            // test to see that the record was updated
            Assert.AreEqual(AllBooks.ThisBook.Title, TestItem.Title);
            Assert.AreEqual(AllBooks.ThisBook.Author, TestItem.Author);
            Assert.AreEqual(AllBooks.ThisBook.PublicationYear, TestItem.PublicationYear);
            Assert.AreEqual(AllBooks.ThisBook.Price, TestItem.Price);
            Assert.AreEqual(AllBooks.ThisBook.Description, TestItem.Description);
            Assert.AreEqual(AllBooks.ThisBook.ImagePath, TestItem.ImagePath);
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
            //############################################### Add Method ####################################################
            [TestMethod]
            public void AddMethodOK()
            {
                // create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();
                // create the item of test data
                clsGenres TestItem = new clsGenres();
                // variable to store the primary key
                Int32 PrimaryKey = 0;
                // set its properties
                TestItem.BookGenre = "Science Fiction";
                TestItem.BookId = 1; // Assuming 1 is a valid BookId for this test
                                     // set ThisGenre to the test data
                AllGenre.ThisGenre = TestItem;
                // add the record
                PrimaryKey = AllGenre.Add();
                // set the primary key of the test data
                TestItem.GenreId = PrimaryKey;
                // find the record
                bool Found = AllGenre.ThisGenre.Find(PrimaryKey);
                // test to see that the two values are the same
                Assert.AreEqual(AllGenre.ThisGenre, TestItem);
            }
            [TestMethod]
            public void UpdateSingleGenreMethodOK()
            {
                // Create an instance of the class we want to create
                clsGenresCollection AllGenre = new clsGenresCollection();
                // Create the item of test data
                clsGenres TestItem = new clsGenres();
                // Variable to store the primary key
                Int32 PrimaryKey = 0;
                // Set its properties
                TestItem.BookGenre = "Original Genre";
                TestItem.BookId = 1; // Assuming 1 is a valid BookId for this test
                                     // Set ThisGenre to the test data
                AllGenre.ThisGenre = TestItem;
                // Add the record
                PrimaryKey = AllGenre.Add();
                // Set the primary key of the test data
                TestItem.GenreId = PrimaryKey;
                // Modify the test data
                TestItem.BookGenre = "Updated Genre";
                TestItem.BookId = 2; // Assuming 2 is another valid BookId for this test
                                     // Set ThisGenre to the updated test data
                AllGenre.ThisGenre = TestItem;
                // Update the record
                AllGenre.Update();
                // Find the record
                bool Found = AllGenre.ThisGenre.Find(PrimaryKey);
                // Test to see that the record was updated
                Assert.AreEqual(AllGenre.ThisGenre.BookGenre, TestItem.BookGenre);
                Assert.AreEqual(AllGenre.ThisGenre.BookId, TestItem.BookId);
            }

        }
    }
    
}
