using System;
using System.Configuration;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        //private data member for the user id property
        private Int32 MUserID;
        //private data member for the user name property
        private string MUserName;
        //private data member for the user name property
        private string MPassword;
        //private data member for the user id property
        private string MDepartment;

        public int UserID
        {
            get
            {
                return MUserID;
            }
            set
            {
                MUserID = value;
            }
        }
        public string Password
        {
            get
            {
                return MPassword;
            }
            set
            {
                MPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return MDepartment;
            }
            set
            {
                MDepartment = value;
            }
        }
        public string UserName
        {
            get
            {
                return MUserName;
            }
            set
            {
                MUserName = value;
            }
        }
       

        public bool FindUser(string userName, string password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the user username and password to search for
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                MUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                MUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                MPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                MDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm evertying worked ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    

    

  
   
    
}






