using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsBookCollection
    {
        List<clsbook> mBookList = new List<clsbook>();

        // Constructor for the class
        public clsBookCollection()
        {
            LoadBooksFromDatabase();
        }

        private void LoadBooksFromDatabase()
        {
            // Variable for the index
            int Index = 0;
            // Variable to store the record count
            int RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to fetch all books
            DB.Execute("sproc_tblbook_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank book object
                clsbook ABook = new clsbook();
                // Read in the fields for the current record
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                ABook.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                ABook.Author = Convert.ToString(DB.DataTable.Rows[Index]["Author"]);
                ABook.PublicationYear = Convert.ToDateTime(DB.DataTable.Rows[Index]["PublicationYear"]);
                ABook.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                ABook.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                ABook.ImagePath = Convert.ToString(DB.DataTable.Rows[Index]["ImagePath"]);
                // Add the record to the private data member
                mBookList.Add(ABook);
                // Point at the next record
                Index++;
            }
        }

        // Removed: private void AddTestData() method to ensure data is always loaded from the database

        public List<clsbook> BookList
        {
            get
            {
                return mBookList;
            }
            set
            {
                mBookList = value;
            }
        }

        public int Count
        {
            get
            {
                return mBookList.Count; // Ensuring this property is readonly
            }
        }

        public clsbook ThisBook { get; set; }
    }
}
