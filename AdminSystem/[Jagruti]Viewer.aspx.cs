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
        clsOrder anOrder = new clsOrder();
        anOrder = (clsOrder)Session["anOrder"];
        Response.Write(anOrder.OrderId);
        Response.Write(anOrder.Address);
        Response.Write(anOrder.TotalCost);
        Response.Write(anOrder.DeliveryDate);


    }
}