using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace Testing3
{

    [TestClass]
    public class tstGenre
    {

        //******************************************************START OF VALIDATION FUNCTION***********************************************************************************//


        string Title = "Romeo"; // Corrected spelling
        string Author = "Shakespeare";
        string PublicationYear = DateTime.Now.Date.ToShortDateString(); // Convert to string
        string Price = "9.99"; // Convert to string
        string Description = "This is a test description for the book.";
        string ImagePath = "/images/book1.jpg"; // Corrected spelling
        string BookGenre = "Romance"; // Corrected spelling
     //######################################################################################################################################                        


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
        public void BookIdPropertyokPropertyOK()
        {
            // Crie uma instância da classe que você deseja testar
            clsbook Book = new clsbook();

            // Crie alguns dados de teste para atribuir à propriedade
            Int32 TestData = 25; // Use int em vez de Int32

            // Atribua os dados à propriedade
            Book.BookId = TestData;

            // Teste para ver se os dois valores são iguais
            Assert.AreEqual(Book.BookId, TestData);
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
            Decimal? TestData = 0.99m;
            Book.Price = TestData;
            Assert.AreEqual(Book.Price, TestData);

        }

        [TestMethod]
        public void BookManagementPropertyoOK()
        {
            clsbook Book = new clsbook();
            string TestData = "Test data";
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
            clsGenres Genre = new clsGenres();
            Assert.IsNotNull(Genre);

        }

        [TestMethod]
        public void GenreIdPropertyOk()
        {
            // Crie uma instância da classe que você deseja testar
            clsGenres Genre = new clsGenres();

            // Crie alguns dados de teste para atribuir à propriedade
            int TestData = 21; // Use int em vez de Int32

            // Atribua os dados à propriedade
            Genre.GenreId = TestData;

            // Teste para ver se os dois valores são iguais
            Assert.AreEqual(Genre.GenreId, TestData);
        }
        [TestMethod]
        public void GenredPropertyOk()
        {
            // Crie uma instância da classe que você deseja testar
            clsGenres Genre = new clsGenres();

            // Crie alguns dados de teste para atribuir à propriedade
            string TestData = "Romeu&Julheta"; // Use int em vez de Int32

            // Atribua os dados à propriedade
            Genre.BookGenre = TestData;

            // Teste para ver se os dois valores são iguais
            Assert.AreEqual(Genre.BookGenre, TestData);
        }

        [TestMethod]
        public void GenrePropertyOk()
        {
            // Crie uma instância da classe que você deseja testar
            clsGenres Genre = new clsGenres();

            // Crie alguns dados de teste para atribuir à propriedade
            Int32 TestData = 21; // Assume que BookId é do tipo int

            // Atribua os dados à propriedade
            Genre.BookId = TestData;

            // Teste para ver se os dois valores são iguais
            Assert.AreEqual(Genre.BookId, TestData);
        }


        //********************************************************************START THE FIND METOD GENRE*****************************************************************************

        [TestMethod]
        public void FindGenreIdMethodOK()
        {
            //create an instance of the class we want to create
            clsGenres Genre = new clsGenres();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            //Boolean OK = true;
            //create some test data to use with the method
            Int32 GenreId = 24;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void FindGenreId2MethodOK()
        {
            //create an instance of the class we want to create
            clsGenres Genre = new clsGenres();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GenreId = 24;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            if (Genre.GenreId != 24)

            {
                OK = false;
            }
            
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindGenrForigianKMethodOK()
        {
            //create an instance of the class we want to create
            clsGenres Genre = new clsGenres();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GenreId = 24;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            if (Genre.BookId != 9)

            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void FindBookGenreMethodOK()
        {
            //create an instance of the class we want to create
            clsGenres Genre = new clsGenres();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GenreId = 24;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            if (Genre.BookGenre != "Romance")

            {
                OK = false;
            }

            Assert.IsTrue(Found);
        }


        //********************************************************FIND METOD Book*************************************************************************
        [TestMethod]
        public void FindMetBoodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            Assert.IsTrue(Found);

        }
        //********************************************************FIND METOD Book*************************************************************************
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            if (Book.BookId != 10)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);

        }


        //********************************************************FIND METOD Book*************************************************************************
        [TestMethod]
        public void FindMetodTitleOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.Title != "Romeeu&Julheta")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }


















        [TestMethod]
        public void FindMetoBookManagementOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the author
            if (Book.BookManagement != "Nuno")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }












        [TestMethod]
        public void FindMetodAuthorOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the author
            if (Book.Author != "Shakespeare")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void FindPriceMetodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.Price != 10)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FindPublicationyearMetodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.PublicationYear != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void FindDescriptionMetodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.Description != "This is my description")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void FindImagePathMetodOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Creat boolean variable to record if the data is ok(assumi it id)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 10;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.ImagePath != "")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }


        //************************************************************LAB 10 VALIDATION DATA BIGINING**************************************************************************
        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsbook Book = new clsbook();

            // string variable to store any error message
            String Error = "";

            // invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //____________________________________________________________START Title TESTING DATA____________________________________________________________________


        [TestMethod]
        public void TitleMin()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = "a"; // This should be ok (1 character)
                                // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = "aa"; // This should be ok (2 characters)
                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = new string('a', 49); // This should be ok (49 characters)
                                                // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = new string('a', 50); // This should be ok (50 characters)
                                                // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = new string('a', 51); // This should fail (51 characters)
                                                // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void TitleMid()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Title = new string('a', 25); // This should be ok (25 characters)
                                                // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");

            //**************************************************END OF TITLE VALIDATION DATA*********************************************************
                             
        
        }

        //________________________________________________STARTING AUTHOR VALIDATION DATA test________________________________________________________

        [TestMethod]
        public void AuthorMin()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = "a"; // This should be ok (1 character)
                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = "aa"; // This should be ok (2 characters)
                                  // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = new string('a', 49); // This should be ok (49 characters)
                                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMax()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = new string('a', 50); // This should be ok (50 characters)
                                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = new string('a', 51); // This should fail (51 characters)
                                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void AuthorMid()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Author = new string('a', 25); // This should be ok (25 characters)
                                                 // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");

             //***************************************************END AUTHOR VALIDATION DATA *****************************************************************
        }
        //________________________________________________________TEST PUBLICATION YEAR START__________________________________________________________________
        [TestMethod]
        public void PublicationYearBelowMin()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is less 75 years
            TestDate = TestDate.AddYears(-75);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMin()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to the minimum valid year (1950)
            TestDate = new DateTime(1950, 1, 1);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMid()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to a mid-range year (2000)
            TestDate = new DateTime(2000, 1, 1);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMax()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to the maximum valid year (2024)
            TestDate = new DateTime(2024, 1, 1);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 1 year
            TestDate = TestDate.AddYears(1);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearExtremeMax()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable
            string PublicationYear = TestDate.ToShortDateString();
            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");

            //***********************************************************END DATA TIME***********************************************

        }

        //_______________________________________________________STARTING PRICE__________________________________________________________


        [TestMethod]
        public void PriceEmpty()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = ""; // This should fail
                               // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceValid()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "£19.99"; // This should be ok
                                     // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidFormat()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "19.99GBP"; // This should fail
                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceNegative()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "-£5.00"; // This should fail
                                     // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceZero()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "£0.00"; // This should fail
                                    // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceTooHigh()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "£10001.00"; // This should fail
                                        // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void PriceHighValue()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string Price = "£9999.99"; // This should be ok
                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");

            //***************************************END TEST PRICE*******************************************
        }


        //__________________________________________START DESRICPTION________________________________________________



        [TestMethod]
        public void DescriptionMin()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = "a"; // This should be ok (1 character)
                                      // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = "aa"; // This should be ok (2 characters)
                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = new string('a', 499); // This should be ok (499 characters)
                                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = new string('a', 500); // This should be ok (500 characters)
                                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = new string('a', 501); // This should fail (501 characters)
                                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void DescriptionMid()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string Description = new string('a', 250); // This should be ok (250 characters)
                                                       // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }















        //__________________________________________START TEST IMAGE___________________________________________________

        [TestMethod]
        public void ImagePathEmpty()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string ImagePath = ""; // This should fail
                                   // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void ImagePathInvalidExtension()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string ImagePath = "image.txt"; // This should fail
                                            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, ""); // Should return an error
        }

        [TestMethod]
        public void ImagePathValidJpg()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string ImagePath = "image.jpg"; // This should be ok
                                            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ImagePathValidPng()
        {
            // Create an instance of the class we want to create
            clsbook Book = new clsbook();
            // String variable to store any error message
            string Error = "";
            // Create some test data to pass to the method
            string ImagePath = "image.png"; // This should be ok
                                            // Invoke the method
            Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //************************************************************LAB 10 VALIDATION DATA BIGINING Genre**************************************************************************


        [TestMethod]
        public void GenreValidation()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";

            string BookGenre = "The genre cannot be empty";
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GenreMin()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = "a";
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = "aa";
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxLessOne()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = new string('a', 49);
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMax()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = new string('a', 50);
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = new string('a', 51);
            Error = Genre.Valid(BookGenre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMid()
        {
            clsGenres Genre = new clsGenres();
            string Error = "";
            string BookGenre = new string('a', 25);
            Error = Genre.Valid(BookGenre);
            Assert.AreEqual(Error, "");
        }
    }


}





