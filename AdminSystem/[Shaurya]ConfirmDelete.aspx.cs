using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store primary key value that has to be deleted from the record
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of staff to be deleted
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create a new instance
        clsStaffCollection StaffDelete = new clsStaffCollection();
        // find the record to be deleted
        StaffDelete.ThisStaff.Find(StaffId);
        // delete the record
        StaffDelete.Delete();
        // redirect to the main page
        Response.Redirect("[Shaurya]List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect to the main page
        Response.Redirect("[Shaurya]List.aspx");
    }
}