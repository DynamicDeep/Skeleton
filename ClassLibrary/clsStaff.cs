using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the address id property 
        private Int32 _StaffId;
        //StaffId public property 
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property 
                return _StaffId;
            }
            set
            {
                //this line of code allows data into property 
                _StaffId = value;
            }
        }
        //private data member for the address
        private Int32 _StaffPhoneNumber;
        //Staff PhoneNumber public property 
        public Int32 StaffPhoneNumber
        {
            get
            {
                //this line of code sends data out of the property 
                return _StaffPhoneNumber;
            }
            set
            {
                //this line of code allows data into property 
                _StaffPhoneNumber = value;
            }
        }
        //private data member for the address
        private string _StaffName;
        //StaffName public property 
        public string StaffName
        {
            get
            {
                //this line of code sends data out of the property 
                return _StaffName;
            }
            set
            {
                //this line of code allows data into property 
                _StaffName = value;
            }
        }
        //private data member for the address
        private string _StaffAddress;
        //StaffAddress public property 
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the property 
                return _StaffAddress;
            }
            set
            {
                //this line of code allows data into property 
                _StaffAddress = value;
            }
        }
        //private data member for the address
        private string _StaffEmail;
        //StaffEmail public property 
        public string StaffEmail
        {
            get
            {
                //this line of code sends data out of the property 
                return _StaffEmail;
            }
            set
            {
                //this line of code allows data into property 
                _StaffEmail = value;
            }
        }
        //private data member for the address
        private Int32 _PositionId;
        //StaffPosition public property 
        public Int32 PositionId
        {
            get
            {
                //this line of code sends data out of the property 
                return _PositionId;
            }
            set
            {
                //this line of code allows data into property 
                _PositionId = value;
            }
        }

        // Find method
        public bool Find(int StaffId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data memebers 
                _StaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                _StaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                _StaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                _StaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                _StaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                _PositionId = Convert.ToInt32(DB.DataTable.Rows[0]["PositionId"]);
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
    }
}