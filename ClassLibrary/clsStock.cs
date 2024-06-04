using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the address id property 
        private Int32 _stockId;
        //StockId public property 
        public Int32 stockId
        {
            get
            {
                //this line of code sends data out of the property 
                return _stockId;
            }
            set
            {
                //this line of code allows data into property 
                _stockId = value;
            }
        }

        private Int32 _BookId;
        public Int32 BookId
        {
            get
            {
                return _BookId;
            }
            set
            {
                _BookId = value;
            }
        }

        private Int32 _SupplierId;
        public Int32 SupplierId
        {
            get
            {
                return _SupplierId;
            }
            set
            {
                _SupplierId = value;
            }
        }

        private Int32 _Quantity;
        public Int32 Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        private DateTime _DateAdded;
        public DateTime DateAdded
        {
            get
            {
                return _DateAdded;
            }
            set
            {
                _DateAdded = value;
            }
        }






        public bool Find(int StockId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for 
            DB.AddParameter("@StockId", StockId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByStockId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data memebers 
                _stockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                _BookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                _Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                _DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                _SupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                //returns that everything worked OK 
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem 
                return false;
            }
        }

        public string Valid(int bookId, int quantity, string dateAdded)
        {
            // Create a String variable to store the error
            string Error = "";

            // Validate BookId
            if (bookId <= 0)
            {
                Error += "The BookId may not be blank or zero: ";
            }
            if (bookId > 1000001)
            {
                Error += "The BookId must be less than or equal to 10: ";
            }

            // Validate Quantity
            if (quantity < 1)
            {
                Error += "The Quantity must be greater than zero: ";
            }
            if (quantity > 100) // Assuming 100 is the maximum valid quantity
            {
                Error += "The Quantity must be less than or equal to 100: ";
            }

            // Validate DateAdded
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error += "The date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future: ";
                }
            }
            catch
            {
                Error += "The date was not a valid date: ";
            }

           

            // Return any error messages
            return Error;
        }

    }
}