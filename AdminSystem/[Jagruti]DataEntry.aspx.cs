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

    public int Orderid { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
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
            AnOrder.TotalCost = price;
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


    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary ley
        int AnOrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AnOrderId = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(AnOrderId);
        if (Found == true)
        {
            //disply the value of the properties in the from
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtTotalCost.Text = AnOrder.TotalCost.ToString();
            txtAddress.Text = AnOrder.Address.ToString();
            txtDeliveryDate.Text = AnOrder.DeliveryDate.ToString();


        }

    }

}