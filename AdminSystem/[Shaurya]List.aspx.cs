using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing1;
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
}