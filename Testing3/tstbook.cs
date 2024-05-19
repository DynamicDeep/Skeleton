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
            public void BookIdPropertyokPropertyOK()
            {
                // Crie uma instância da classe que você deseja testar
                clsbook Book = new clsbook();

                // Crie alguns dados de teste para atribuir à propriedade
                int TestData = 1; // Use int em vez de Int32

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
                // Crie uma instância da classe que você deseja testar
                clsGenre Genre = new clsGenre();

                // Crie alguns dados de teste para atribuir à propriedade
                int TestData = 1; // Use int em vez de Int32

                // Atribua os dados à propriedade
                Genre.GenreId = TestData;

                // Teste para ver se os dois valores são iguais
                Assert.AreEqual(Genre.GenreId, TestData);
            }
            [TestMethod]
            public void GenredPropertyOk()
            {
                // Crie uma instância da classe que você deseja testar
                clsGenre Genre = new clsGenre();

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
                clsGenre Genre = new clsGenre();

                // Crie alguns dados de teste para atribuir à propriedade
                int TestData = 1; // Assume que BookId é do tipo int

                // Atribua os dados à propriedade
                Genre.BookId = TestData;

                // Teste para ver se os dois valores são iguais
                Assert.AreEqual(Genre.BookId, TestData);
            }

        }


    }
}
