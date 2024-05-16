using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        
    }

    protected void btn_Cancel(object sender, EventArgs e)
    {

    }

    

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void TextOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDateofOrder_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        // Create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // Assign the value from lblOrderId Label to OrderId property
        int orderId;
        if (int.TryParse(lblOrderID.Text, out orderId))
        {
            AnOrder.OrderId = orderId;
        }
        else
        {
            // Handle the case where lblOrderID.Text cannot be parsed to an integer
        }
        // Assuming lblOrderId is the correct Label ID

        // Convert lblAddress.Text to string and assign it to Address property
        AnOrder.Address = lblAddress.Text; // Assuming lblAddress is the correct Label ID

        // Convert lblPrice.Text to string and assign it to Price property
        int price;
        if (int.TryParse(lblPrice.Text, out price))
        {
            AnOrder.Price = price;
        }
        else
        {
            // Handle the case where lblPrice.Text cannot be parsed to an integer
        }
        // Assuming lblPrice is the correct Label ID

        // Store AnOrder object in session
        Session["AnOrder"] = AnOrder;

        // Redirect to AddressBookViewer.aspx page
        Response.Redirect("[Jagruti]Viewer.aspx");
    }

}