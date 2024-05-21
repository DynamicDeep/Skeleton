using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{

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
            Decimal TestData = 0.99m;
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
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GenreId = 21;
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
            Int32 GenreId = 21;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            if (Genre.GenreId != 21)

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
            Int32 GenreId = 21;
            //invoke the method
            Found = Genre.Find(GenreId);
            //check the addess
            if (Genre.BookId != 21)

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
            Int32 GenreId = 21;
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
            Int32 BookId = 21;
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
            Int32 BookId = 21;
            //invoke the method
            Found = Book.Find(BookId);
            if (Book.BookId != 21)
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
            Int32 BookId = 21;
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
        public void FindMetodStafManagementOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 21;
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
        public void FindMetodAuthorOK()
        {
            //create an instance of the class we want to create
            clsbook Book = new clsbook();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookId = 21;
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
            Int32 BookId = 21;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.Price != 0.99m)
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
            Int32 BookId = 21;
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
            Int32 BookId = 21;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.Description !="This is my description")
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
            Int32 BookId = 21;
            //invoke the method
            Found = Book.Find(BookId);
            //check the addess
            if (Book.ImagePath != "/images/book1.jpg")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);


        }
    }
}