using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayStaffMembers();
        }
    }

    void DisplayStaffMembers()
    {
        // Assuming clsStaffCollection is implemented and populated with data
        clsStaffCollection StaffCollection = new clsStaffCollection();

        // Assuming lstStaffList is the ID of your ListBox control in the .aspx file
        lstStaffList.DataSource = StaffCollection.StaffList;

        // Assuming StaffId and StaffName are properties of clsStaff class
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataTextField = "StaffEmail";
        lstStaffList.DataTextField = "StaffAddress";
        lstStaffList.DataTextField = "StaffPhoneNumber";
        lstStaffList.DataTextField = "PositionID";

        // Binding data to the ListBox control
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate it's a new record
        Session["StaffID"] = -1;

        // Redirect to the data entry page for staff
        Response.Redirect("[Shaurya]DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 StaffId;

        // If a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);

            // Store the data in the session object
            Session["StaffId"] = StaffId;

            // Redirect to the edit page
            Response.Redirect("[Shaurya]DataEntry.aspx");
        }
        else // If no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit.";
        }
    }

}