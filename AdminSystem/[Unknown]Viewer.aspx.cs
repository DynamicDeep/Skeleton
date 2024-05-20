using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress 
        clsSupplier aSupplier = new clsSupplier();

        //get the data from the session object 
        aSupplier = (clsSupplier)Session["aSupplier"];

        //display the Supplier Name for this entry
        Response.Write("Supplier Name:  " + aSupplier.SupplierName + "<br/>");

        //display the Contact Info for this entry
        Response.Write("Contact No: " + aSupplier.ContactNo + "<br/>");

        //display the Address for this entry
        Response.Write("Address: " + aSupplier.SupplierAddress + "<br/>");

        //display the Supplier Email Id for this entry 
        Response.Write("Supplier Email Id: " + aSupplier.SupplierEmailId + "<br/>");
    }
}