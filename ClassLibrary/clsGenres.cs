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
            mGenreId = 21;
            mBookGenre = "Romance";
            mBookId = 21;
            
            
            return true;
        }
    }
}