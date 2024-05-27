using System;

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
    }
}