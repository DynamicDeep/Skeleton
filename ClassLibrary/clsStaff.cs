using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            //add the parameter for the staff id to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
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
        //Validation Method
        public string Valid(int PositionID, string StaffName, string StaffEmail, string StaffAddress, string StaffPhoneNumber)
        {
            // Create a String variable to store the error
            string Error = "";

            // Validate PositionID
            if (PositionID <= 0)
            {
                Error += "The PositionID may not be blank or zero. ";
            }
            if (PositionID > 10)
            {
                Error += "The PositionID must be less than or equal to 10. ";
            }

            // Validation for StaffName
            if (string.IsNullOrWhiteSpace(StaffName))
            {
                Error += "Staff Name cannot be blank. ";
            }
            else if (StaffName.Length < 2 || StaffName.Length > 50)
            {
                Error += "Staff Name must be between 2 and 50 characters. ";
            }

            // Validation for StaffEmail
            if (string.IsNullOrWhiteSpace(StaffEmail))
            {
                Error += "Staff Email cannot be blank. ";
            }
            else if (!IsValidEmail(StaffEmail))
            {
                Error += "Staff Email is not in a valid format. ";
            }

            // Validation for StaffAddress
            if (string.IsNullOrWhiteSpace(StaffAddress))
            {
                Error += "Staff Address cannot be blank. ";
            }
            else if (StaffAddress.Length > 100)
            {
                Error += "Staff Address must be less than 100 characters. ";
            }

            // Validation for StaffPhoneNumber
            if (string.IsNullOrWhiteSpace(StaffPhoneNumber))
            {
                Error += "Staff Phone Number cannot be blank. ";
            }
            else if (!Regex.IsMatch(StaffPhoneNumber, @"^\d{6}$"))
            {
                Error += "Staff Phone Number must contain exactly six digits. ";
            }

            // Return any error messages
            return Error;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}