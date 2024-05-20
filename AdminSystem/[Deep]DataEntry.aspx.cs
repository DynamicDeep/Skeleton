using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOrder_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStock aStock = new clsStock();

        //capture the BookId 
        aStock.BookId = int.Parse(TextBoxBookNo.Text);

        //capture the Quantity
        aStock.Quantity = int.Parse(TextBoxQuantity.Text);

        //capture the date
        aStock.DateAdded = DateTime.Parse(TextBoxDateAdded.Text);

        //capture the supplier Id
        aStock.SupplierId = int.Parse(TextBoxSupplierID.Text);

        //store the BookId in the session object
        Session["aStock"] = aStock;

        //navigate to the view page 
        Response.Redirect("[Deep]Viewer.aspx");
    }

    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {

    }
}