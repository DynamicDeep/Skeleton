using System;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Net;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrder
    {

        private int mOrderId;
        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        private int mCustomerId;
        public int CustomerId

        {
            get { return mCustomerId; }
            set { mCustomerId = value; }

        }
        private double mTotalCost;
        public double TotalCost
        {
            get { return mTotalCost; }
            set { mTotalCost = value; }
        }

        private string mAddress;
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        private DateTime mDeliveryDate;
        public DateTime DeliveryDate
        {
            get { return mDeliveryDate; }
            set { mDeliveryDate = value; }
        }

        public int Orderid { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }

        public bool Find(int OrderId)
        {
            //create an instace of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paarmeter for the address id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FiltersOrdersByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mTotalCost = Convert.ToDouble(DB.DataTable.Rows[0]["TotalCost"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;

            }
        }

        

        public string Valid(string CustomerId, string TotalCost, string Address, string DeliveryDate)
        {
            string Error = "";
            DateTime DateTemp;

            DateTemp = Convert.ToDateTime(DeliveryDate);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The data cannot be in the past : ";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }

            return Error;
        }

    }
}
           

           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
    
      


      
       