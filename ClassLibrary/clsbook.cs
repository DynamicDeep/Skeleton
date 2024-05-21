using System;

namespace ClassLibrary
{

    public class clsbook
    {
        
        
       
        //Book ID Find Method
        private   Int32 mBookId;
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
        private decimal mPrice;
        public decimal Price 
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
            mBookId = 21;
            mTitle = "Romeeu&Julheta";
            mAuthor = "Shakespeare";
            mPublicationYear = Convert.ToDateTime("23/12/2022");
            mPrice = 0.99m;
            mDescription = "This is my description";
            mImagePath = "/images/book1.jpg";

            //always retun true
            return true;

        }


       
    }
}