using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        // private data member for the Supplier Id Property
        private Int32 mSupplierId;
        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }
        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private Int32 mContactNo;
        public int ContactNo
        {
            get
            {
                return mContactNo;
            }
            set
            {
                mContactNo = value;
            }
        }
        private string mEmailId;
        public string EmailId
        {
            get
            {
                return mEmailId;
            }
            set
            {
                mEmailId = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private DateTime mSupplierDate;
        public DateTime SupplierDate
        {
            get
            {
                return mSupplierDate;
            }
            set
            {
                mSupplierDate = value;
            }
        }

        public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", SupplierId);
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            if(DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]); 
                mContactNo = Convert.ToInt32(DB.DataTable.Rows[0]["ContactNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailId = Convert.ToString(DB.DataTable.Rows[0]["Email_ID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); ;
                mSupplierDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDate"]);
                return true;
            }
            else
            {
                return false;
            }
            
           
        }

        public string Valid(string name, string contactNo, string address, string emailId, string supplierDate)
        {
            //create a string variable to store the error 
            string Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Name is black 
            if(Name.Length == 0)
            {
                Error = Error + "The house number may not be black : ";
            }
            if(Name.Length > 50)
            {
                //record the error
                Error = Error + "The house must be less than 50 charcters : ";
            }
            //copy the SupplierDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(SupplierDate);
            //check to see if the date is less than today's date 
            if(DateTemp< DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //retutn any error messages 
            return Error;
        }
    }
}