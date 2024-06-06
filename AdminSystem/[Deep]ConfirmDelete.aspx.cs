using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted 
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Stock to be deleted from the session object 
        StockId = Convert.ToInt32(Session["StockId"]);
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page 
        Response.Redirect("[Deep]List.aspx");
    }

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Stock book collection class 
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete 
        StockBook.ThisStock.Find(StockId);
        //delete the record 
        StockBook.Delete();
        //redirect back to the main page 
        Response.Redirect("[Deep]List.aspx");


    }
}