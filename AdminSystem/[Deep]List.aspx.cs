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
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection stock = new clsStockCollection();
        lstStockList.DataSource = stock.StockList;
        lstStockList.DataValueField = "stockId";
        lstStockList.DataTextField = "BookId";
        lstStockList.DataBind();    

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate it's a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("[Deep]DataEntry.aspx");
    }
}