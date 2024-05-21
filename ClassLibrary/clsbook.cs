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
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the book ID to search for
            DB.AddParameter("@BookId", bookId);

            // Execute the stored procedure
            DB.Execute("sproc_tblbook_FilterByBookId");

            // Check if a record was found
            if (DB.Count == 1)
            {
                try
                {
                    mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                    mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                    mAuthor = Convert.ToString(DB.DataTable.Rows[0]["Author"]);
                    mPublicationYear = Convert.ToDateTime(DB.DataTable.Rows[0]["PublicationYear"]);

                    string priceStr = DB.DataTable.Rows[0]["Price"].ToString();
                    if (decimal.TryParse(priceStr, out decimal price))
                    {
                        mPrice = price;
                    }
                    else
                    {
                        mPrice = null; // or set to a default value
                    }

                    mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                    mImagePath = Convert.ToString(DB.DataTable.Rows[0]["ImagePath"]);
                    mBookManagemente = Convert.ToString(DB.DataTable.Rows[0]["BookManagement"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in Find method: {ex.Message}");
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
