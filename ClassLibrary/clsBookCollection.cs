using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        private List<clsbook> mBookList = new List<clsbook>();
        private clsbook mThisBook = new clsbook();

        public clsBookCollection()
        {
            LoadBooksFromDatabase();
        }

        private void LoadBooksFromDatabase()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblbook_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsbook ABook = new clsbook();
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                ABook.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                ABook.Author = Convert.ToString(DB.DataTable.Rows[Index]["Author"]);
                ABook.PublicationYear = Convert.ToDateTime(DB.DataTable.Rows[Index]["PublicationYear"]);
                ABook.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                ABook.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                ABook.BookManagement = Convert.ToString(DB.DataTable.Rows[Index]["BookManagement"]);
                ABook.ImagePath = Convert.ToString(DB.DataTable.Rows[Index]["ImagePath"]);

                mBookList.Add(ABook);
                Index++;
            }
        }

        public int Add()
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@Title", mThisBook.Title);
                DB.AddParameter("@Author", mThisBook.Author);
                DB.AddParameter("@PublicationYear", mThisBook.PublicationYear);
                DB.AddParameter("@Price", mThisBook.Price);
                DB.AddParameter("@Description", mThisBook.Description);
                DB.AddParameter("@ImagePath", mThisBook.ImagePath);  // Certifique-se de que esta é uma string base64

                return DB.Execute("sproc_tblbook_Insert");
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new book: " + ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();

                DB.AddParameter("@BookId", mThisBook.BookId);
                DB.AddParameter("@Title", mThisBook.Title);
                DB.AddParameter("@Author", mThisBook.Author);
                DB.AddParameter("@PublicationYear", mThisBook.PublicationYear);
                DB.AddParameter("@Price", mThisBook.Price);
                DB.AddParameter("@Description", mThisBook.Description);
                DB.AddParameter("@ImagePath", mThisBook.ImagePath);  // Certifique-se de que esta é uma string base64

                DB.Execute("sproc_tblBook_Update");
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating book: " + ex.Message);
            }
        }

        public List<clsbook> BookList
        {
            get { return mBookList; }
            set { mBookList = value; }
        }

        public int Count
        {
            get { return mBookList.Count; }
        }

        public clsbook ThisBook
        {
            get { return mThisBook; }
            set { mThisBook = value; }
        }
    }
}
