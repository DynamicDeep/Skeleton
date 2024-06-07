using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void StockButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockBookLogin.aspx");
    }

    protected void StaffButton_Click(object sender, EventArgs e)
    {

    }

    protected void CustomerButton_Click(object sender, EventArgs e)
    {

    }

    protected void SupplierButton_Click(object sender, EventArgs e)
    {

    }

    protected void OrderButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderBookLogin.aspx");
    }

    protected void BookButton_Click(object sender, EventArgs e)
    {

    }
}