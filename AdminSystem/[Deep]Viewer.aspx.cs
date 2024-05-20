using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress 
        clsStock aStock = new clsStock();

        //get the data from the session object 
        aStock = (clsStock)Session["aStock"];

        //display the house number for this entry
        Response.Write( "Book ID:  " + aStock.BookId + "<br/>"); 

        //display the Quantity for this entry
        Response.Write("Quantity: " + aStock.Quantity + "<br/>");

        //display the Date for this entry
        Response.Write("Date: " + aStock.DateAdded.ToShortDateString() + "<br/>");

        //display the SupplierId for this entry 
        Response.Write("Supplier ID: " + aStock.SupplierId + "<br/>");

    }
}