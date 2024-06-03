using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsGenresCollection
    {
        List<clsGenres> mGenreList = new List<clsGenres>();

        // Constructor of the class
        public clsGenresCollection()
        {
            LoadGenresFromDatabase();
        }

        private void LoadGenresFromDatabase()
        {
            // Variable for the index
            int Index = 0;
            // Variable to store the record count
            int RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Executes the stored procedure to fetch all genres
            DB.Execute("sproc_Genre_SelectAll");
            // Gets the record count
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank genre object
                clsGenres AGenre = new clsGenres();
                // Read the fields of the current record
                AGenre.GenreId = Convert.ToInt32(DB.DataTable.Rows[Index]["GenreId"]);
                AGenre.BookGenre = Convert.ToString(DB.DataTable.Rows[Index]["BookGenre"]);
                AGenre.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                // Add the record to the private data member
                mGenreList.Add(AGenre);
                // Point to the next record
                Index++;
            }
        }

        public List<clsGenres> GenreList
        {
            get
            {
                return mGenreList;
            }
            set
            {
                mGenreList = value;
            }
        }

        public int Count
        {
            get
            {
                return mGenreList.Count;
            }
            // Removendo o setter para garantir que a propriedade seja somente leitura
        }

        public clsGenres ThisGenre { get; set; }
    }
}
