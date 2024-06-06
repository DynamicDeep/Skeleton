using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrdersId"]);

    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create a new intance of the address book collection class
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderId);
        OrderBook.Delete();
        //redirect back to the main page
        Response.Redirect("[Jagruti]list.aspx");
    }



    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
       
        Response.Redirect("[Jagruti]list.aspx");
    }
}
