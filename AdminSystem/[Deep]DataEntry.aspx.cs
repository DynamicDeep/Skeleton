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

        //create a new instance of clsStockId
        aStock.stockId = int.Parse(TextBoxStockId.Text);

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

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class 
        clsStock aStock = new clsStock();
        //create a variable to store the primary key 
        Int32 StockId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        StockId = Convert.ToInt32(TextBoxStockId.Text);
        //get the primary key entered by the user 
        Found = aStock.Find(StockId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            TextBoxBookNo.Text = aStock.BookId.ToString();
            TextBoxDateAdded.Text = aStock.DateAdded.ToShortDateString();
            TextBoxQuantity.Text = aStock.Quantity.ToString();
            TextBoxSupplierID.Text = aStock.SupplierId.ToString();

        }
    }
}