using System;
using System.Collections.Generic;
using System.Dynamic;
using ClassLibrary;


namespace ClassLibrary
{
    public class clsOrderCollection
    {

        
        //private data member for the list
        List<clsOrder> MOrderList = new List<clsOrder>();

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
            DB.Execute("sproc_tblOrders_selecAll");
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

        

    }
    
            
    }