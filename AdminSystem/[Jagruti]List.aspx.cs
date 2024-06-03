using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected ListBox lstOrderList; // Assuming lstOrderList is a ListBox

    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (!IsPostBack)
        {
            // update the list box
            DisplayOrder();
        }
    }

    void DisplayOrder()
    {
        // create an instance of the Order collection
        clsOrderCollection Order = new clsOrderCollection();

        // set the data source to the list of Orders in the collection
        lstOrderList.DataSource = Order.OrderList;

        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";

        // set the data field to display
        lstOrderList.DataTextField = "TotalCost";

        // bind the data to the list
        lstOrderList.DataBind();
    }
}
