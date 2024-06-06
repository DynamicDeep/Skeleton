using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    public class clsStaffCollection
    {
        // Private data member of the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //public property of the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        //Property for count
        public int Count
        {
            get
            {
                //Return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //Updating soon
            }
        }
        public clsStaff ThisStaff { get; set; }

        // Constructor
        public clsStaffCollection()
        {
            // Variable for the index
            int Index = 0;
            // Variable to store the record count 
            int RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_TblStaff_SelectAll");
            // Get the count of the records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank staff member 
                clsStaff AStaff = new clsStaff();
                //Read in the fields for the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
                AStaff.PositionID = Convert.ToInt32(DB.DataTable.Rows[Index]["PositionID"]); ;
                // Add the staff member to the private data member 
                mStaffList.Add(AStaff);
                // Point at the next record
                Index++;
            }
        }
    }

}