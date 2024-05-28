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
        public bool Find(int staffId)
        {
            // Hardcoding the test data for demonstration purposes
            if (staffId == 1)
            {
                this.StaffId = 1;
                this.StaffName = "Will";
                this.StaffEmail = "will@123.com";
                this.StaffPhoneNumber = 123456;
                this.PositionId = 1;
                return true;
            }
            else
            {
                // If staffId does not match, return false
                return false;
            }
        }
    }
}