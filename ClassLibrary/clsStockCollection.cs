using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> _StockList = new List<clsStock>();
        //private data member for the thisStock
        clsStock _ThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return _StockList;
            }

            set
            {
                //return the private data
                _StockList = value;
            }
        }
        public int Count
        {
            get
            {
                return _StockList.Count;
            }

            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return _ThisStock;
            }
            set
            {
                _ThisStock = value;
            }
        }


        public clsStockCollection()
        {
           //object for data connection 
           clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the values of _thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookId", _ThisStock.BookId);
            DB.AddParameter("@Quantity", _ThisStock.Quantity);
            DB.AddParameter("@DateAdded", _ThisStock.DateAdded);
            DB.AddParameter("@SupplierId", _ThisStock.SupplierId);
            DB.AddParameter("@StockName", _ThisStock.StockName);


            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure 
            DB.AddParameter("@StockId", _ThisStock.stockId);
            DB.AddParameter("@BookId", _ThisStock.BookId);
            DB.AddParameter("@Quantity", _ThisStock.Quantity);
            DB.AddParameter("@DateAdded", _ThisStock.DateAdded);
            DB.AddParameter("@SupplierId", _ThisStock.SupplierId);
            DB.AddParameter("@StockName", _ThisStock.StockName) ;
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@StockId", _ThisStock.stockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByStockName(string StockName)
        {
            //filters the record based on a full or partial stock name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StockName parameter to the database
            DB.AddParameter("@StockName", StockName);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            _StockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock 
                clsStock aStock = new clsStock();
                aStock.stockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                aStock.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                aStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                aStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aStock.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                aStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);

                //add the records to the private data member 
                _StockList.Add(aStock);
                //point at the next record
                Index++;
            }
        }
    }
}