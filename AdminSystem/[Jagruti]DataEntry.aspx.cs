using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // Capture the OrderId
        string OrderId = txtOrderID.Text;

        // Capture the CustomerId
        string CustomerId = txtCustomerId.Text;

        // Capture the TotalCost
        string TotalCost = txtTotalCost.Text;

        // Capture the Address
        string Address = txtAddress.Text;

        // Capture the DeliveryDate
        string DeliveryDate = txtDeliveryDate.Text;

        // Validate error
        string Error = "";

        // Validate the data
        Error = AnOrder.Valid(OrderId, TotalCost, Address, DeliveryDate);
        if (Error == "")
        {
            // Set the properties of AnOrder
            AnOrder.Address = Address;
            AnOrder.TotalCost = Convert.ToDouble(TotalCost);
            AnOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);

            // Store the AnOrder in the session object
            Session["AnOrder"] = AnOrder;

            // Navigate customer to the order page
            Response.Redirect("JagrutiViewer.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {

    }
}