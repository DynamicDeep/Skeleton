using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public List<clsOrder> OrderCollectionOrderList

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
                return MOrderList.Count;

            }
            set
            {

                //we shall worry about this later
            }
        }

        public clsOrder ThisOrder { get; set; }
        public List<clsOrder> OrderList { get; set; }


        //contructor for the class
        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for data connect
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure9
            DB.Execute("sproc_tblOrders_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrder AnOrder = new clsOrder();
                //read in the field for the current record]
                //AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.TotalCost = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalCost"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                //add the recorder to the private data member
                MOrderList.Add(AnOrder);
                //point at the next record
                Index++;

            }
        }

        public int Add()
        {
            //Adds a record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paparmeters for the stored procedure
            DB.AddParameter("clsCustomer", MThisOrder.CustomerId);
            DB.AddParameter("TotalCost", MThisOrder.TotalCost);
            DB.AddParameter("Address", MThisOrder.Address);
            DB.AddParameter("DeliveryDate", MThisOrder.DeliveryDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of This Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", MThisOrder.CustomerId);
            DB.AddParameter("TotalCost", MThisOrder.TotalCost);
            DB.AddParameter("Address", MThisOrder.Address);
            DB.AddParameter("DeliveryDate", MThisOrder.DeliveryDate);
            //execute the stored produre
            DB.Execute("sproc_TblOrder_Update");
        }
    }
}
        