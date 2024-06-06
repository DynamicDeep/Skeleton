using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        //private data member for the user Name property
        private string mUserName;
        //private data member for the user Password property
        private string mUserPassword;
        //private data member for the user Department property
        private string mUserDepartment;
        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mUserPassword;
            }
            set
            {
                mUserPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mUserDepartment;
            }
            set
            {
                mUserDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblUsers_FindUserNewPw");
            if(DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["[UserName]"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["[Password]"]);
                mUserDepartment = Convert.ToString(DB.DataTable.Rows[0]["[Department]"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}