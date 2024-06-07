using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //public property for thisOrder

        //private data member for the list
        List<clsOrder> MOrderList = new List<clsOrder>();

        //private member data for thisOrder
        clsOrder MThisOrder = new clsOrder();

        //public property for the address list
        public List<clsOrder> OrderList

        {
            get
            {
                //return the private data
                return MOrderList;

            }
            set
            {
                //set the private data
                MOrderList = value;

            }
        }
        //public propery for count
        public int Count

        {
            get
            {
                //return the count of the list
                return OrderList.Count;

            }
            set
            {

                //we shall worry about this later
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return MThisOrder;
            }
            set
            {
                MThisOrder = value;
            }
        }


        //contructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_selectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //Adds a record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paparmeters for the stored procedure
            DB.AddParameter("@CustomerID", MThisOrder.CustomerId);
            DB.AddParameter("@TotalCost", MThisOrder.TotalCost);
            DB.AddParameter("@Address", MThisOrder.Address);
            DB.AddParameter("@DeliveryDate", MThisOrder.DeliveryDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of This Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", MThisOrder.Orderid);
            DB.AddParameter("@CustomerID", MThisOrder.CustomerId);
            DB.AddParameter("TotalCost", MThisOrder.TotalCost);
            DB.AddParameter("Address", MThisOrder.Address);
            DB.AddParameter("DeliveryDate", MThisOrder.DeliveryDate);
            //execute the stored produre
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            {
                //update an existing record based on the values of This Order
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@OrderID", MThisOrder.OrderId);

                //execute the stored procedure
                DB.Execute("sproc_TblOrder_Delete");
            }
        }

        public void ReportByAddress(string OrderAddress)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Address", OrderAddress);
            //execute the stored procedure
            DB.Execute("sproc_TblOrders_FilterByAddressNoneFound");
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
            MOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.TotalCost = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalCost"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                MOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

       
    }
}
