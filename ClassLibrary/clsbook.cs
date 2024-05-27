using System;
using System.Globalization;
using System.IO;

namespace ClassLibrary
{

    public class clsbook
    {



        //Book ID Find Method
        private Int32 mBookId;
        public int BookId
        {
            get
            {
                return mBookId;
            }
            set
            {
                mBookId = value;
            }
        }
        //Tilte find method
        private string mTitle;
        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
            }
        }
        //find outhor metod
        private string mAuthor;
        public string Author
        {
            get
            {
                return mAuthor;
            }
            set
            {
                mAuthor = value;
            }
        }
        private DateTime mPublicationYear;
        public DateTime PublicationYear
        {
            get
            {
                return mPublicationYear;
            }
            set
            {
                mPublicationYear = value;
            }
        }

        //FIND PRICE
        private decimal? mPrice;
        public decimal? Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        //DESCRIPTION
        private string mDescription;
        public string Description
        {
            get
            {
                return mDescription; // Return the backing field, not the property itself
            }
            set
            {
                mDescription = value;
            }
        }
        //Forigian K
        private string mBookManagemente;
        public string BookManagement
        {
            get
            {
                return mBookManagemente;
            }
            set
            {
                mBookManagemente = value;
            }
        }

        //Image
        private string mImagePath;
        public string ImagePath
        {
            get
            {
                return mImagePath;
            }
            set
            {
                mImagePath = value;
            }
        }
        //______________________________________DATA BASE CONECTION______________________________________________________
        public bool Find(int bookId)
        {
            // Crie uma instância da conexão de dados
            clsDataConnection DB = new clsDataConnection();

            // Adicione o parâmetro para a busca
            DB.AddParameter("@BookId", bookId);

            // Execute o procedimento armazenado
            DB.Execute("sproc_tblbook_FilterByBookId");

            // Se um registro for encontrado (deve haver um ou nenhum)
            if (DB.Count == 1)
            {
                // Copie os dados do banco de dados para as propriedades da classe
                BookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                Title = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                Author = Convert.ToString(DB.DataTable.Rows[0]["Author"]);
                PublicationYear = Convert.ToDateTime(DB.DataTable.Rows[0]["PublicationYear"]);
                Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                Price = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                BookManagement = Convert.ToString(DB.DataTable.Rows[0]["BookManagement"]);
                ImagePath = Convert.ToString(DB.DataTable.Rows[0]["ImagePath"]);
                // Retorne true indicando que tudo funcionou corretamente
                return true;
            }
            else
            {
                // Se nenhum registro foi encontrado
                return false;
            }
        }
        //_____________________________________________________VALIDATION METHOD---------------------------------------------------------
        public string Valid(string title, string author, string publicationYear, string price, string description, string imagePath)
        {
            string Error = "";

            // Validate Title
            if (string.IsNullOrEmpty(title))
            {
                Error += "The title cannot be empty. ";
            }
            else if (title.Length < 1)
            {
                Error += "The title cannot have less than 1 character. ";
            }
            else if (title.Length > 50)
            {
                Error += "The title cannot have more than 50 characters. ";
            }


            // Validate Author
            if (string.IsNullOrEmpty(author))
            {
                Error += "The author cannot be empty. ";
            }
            else if (author.Length < 1)
            {
                Error += "The author cannot have less than 1 character. ";
            }
            else if (author.Length > 50)
            {
                Error += "The author cannot have more than 50 characters. ";
            }



            // Validate publicationYear
            DateTime pubYearDate;
            if (!DateTime.TryParse(publicationYear, out pubYearDate))
            {
                Error += "The publication year must be a valid date. ";
            }
            else if (pubYearDate.Year < 1950 || pubYearDate.Year > 2024)
            {
                Error += "The publication year must be between 1950 and 2024. ";
            }


            // Validate Price
            if (string.IsNullOrEmpty(price))
            {
                Error += "Price cannot be empty; ";
            }
            else if (!decimal.TryParse(price, NumberStyles.Currency, new CultureInfo("en-GB"), out decimal parsedPrice))
            {
                Error += "Price must be a valid decimal number in GBP; ";
            }
            else if (parsedPrice <= 0)
            {
                Error += "Price must be greater than zero; ";
            }
            else if (parsedPrice > 10000) // Assuming 10,000 as an upper reasonable limit for the price
            {
                Error += "Price is too high; ";
            }

            //Validate description

            // Validation for Description
            if (string.IsNullOrEmpty(description))
            {
                Error += "Description cannot be null or empty; ";
            }
            else if (description.Length < 1 || description.Length > 500)
            {
                Error += "Description must be between 1 and 500 characters; ";
            }






            // Validate ImagePath
            if (string.IsNullOrEmpty(imagePath))
            {
               Error += "Image path cannot be empty; ";
            }
            else
            {
                string extension = Path.GetExtension(imagePath).ToLower();
                if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".gif")
                {
                    Error += "Image path must be a valid image file (.jpg, .jpeg, .png, .gif); ";
                }
            }

        




            return Error;
        }
    
    
    }
}