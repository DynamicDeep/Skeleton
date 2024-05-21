using System;

namespace ClassLibrary
{
    public class clsGenres
    {
        private int mGenreId;
        public int GenreId
        {
            get
            { return mGenreId; }

            set
            {
                mGenreId = value;
            }
        }
        private string mBookGenre;
        public string BookGenre
        {
            get
            {
                return mBookGenre;
            }
            set
            {
                mBookGenre = value;
            }
        }
        private int mBookId;
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

        public bool Find(int genreId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the GenreId to search for
            DB.AddParameter("@GenreId", genreId);

            // Execute the stored procedure
            DB.Execute("sproc_Genre_FilterByGenreId");

            // If one record is found (Count should be 1)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mGenreId = Convert.ToInt32(DB.DataTable.Rows[0]["GenreId"]);
                mBookGenre = Convert.ToString(DB.DataTable.Rows[0]["BookGenre"]);
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);

                // Return true indicating success
                return true;
            }
            else
            {
                // If no record is found, return false
                return false;
            }
        }
    }
}