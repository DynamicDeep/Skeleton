using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Private data member of the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // Private data member for the ThisStaff
        clsStaff _ThisStaff = new clsStaff();

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
        // Public property for accessing ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                return _ThisStaff;
            }
            set
            {
                _ThisStaff = value;
            }
        }

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
        public int Add()
        {
            // Adds a record to the database based on the values of ThisStaff
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", _ThisStaff.StaffId);
            DB.AddParameter("@StaffName", _ThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", _ThisStaff.StaffEmail);
            DB.AddParameter("@StaffAddress", _ThisStaff.StaffAddress);
            DB.AddParameter("@StaffPhoneNumber", _ThisStaff.StaffPhoneNumber);
            DB.AddParameter("@PositionID", _ThisStaff.PositionID);

            // Execute the query returning the primary key value
            return DB.Execute("sproc_TblStaff_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of ThisStaff
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", _ThisStaff.StaffId);
            DB.AddParameter("@StaffName", _ThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", _ThisStaff.StaffEmail);
            DB.AddParameter("@StaffAddress", _ThisStaff.StaffAddress);
            DB.AddParameter("@StaffPhoneNumber", _ThisStaff.StaffPhoneNumber);
            DB.AddParameter("@PositionID", _ThisStaff.PositionID);

            // Execute the query
            DB.Execute("sproc_TblStaff_Update");
        }

        public void Delete()
        {
            // Deletes a record from the database based on the primary key value
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameter for the stored procedure
            DB.AddParameter("@StaffId", _ThisStaff.StaffId);

            // Execute the query to delete the record
            DB.Execute("sproc_TblStaff_Delete");
        }
    }

}