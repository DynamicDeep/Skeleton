using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create an instance class
        clsStaff AStaff = new clsStaff();
        //Get data from the Session
        AStaff = (clsStaff)Session["AStaff"];
        //Display entires
        Response.Write("Staff ID: " + AStaff.StaffId + "<br/>");
        Response.Write("Staff Name: " + AStaff.StaffName + "<br/>");
        Response.Write("Staff Address: " + AStaff.StaffAddress + "<br/>");
        Response.Write("Staff Email: " + AStaff.StaffEmail + "<br/>");
        Response.Write("Staff Phone Number: " + AStaff.StaffPhoneNumber + "<br/>");
        Response.Write("Staff PositionID : " + AStaff.PositionID + "<br/>");
    }
}
