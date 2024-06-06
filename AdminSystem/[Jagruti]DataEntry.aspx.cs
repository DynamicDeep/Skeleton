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
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // converts the OrderId from the session to an int
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (!IsPostBack==false)
        {
           if (OrderId != -1)
           {
                DisplayaOrder();
           }
        }
    }
    protected void BtnOK_Click(object sender, EventArgs e)
    {
        // Create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

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
        Error = AnOrder.Valid(CustomerId,TotalCost, Address, DeliveryDate);
        if (Error == "")
        {
           
            // Set the properties of AnOrder
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.Address = Convert.ToString(Address); 
            AnOrder.TotalCost = Convert.ToDouble(TotalCost);
            AnOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);

            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderId == -1)
            {
                //Set the ThisAddress proprty
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();

            }
            //otherwise is must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }

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
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the priamry key ennterd by the user
        OrderId = Convert.ToInt32(txtOrderID.Text);
        //find the record 
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtAddress.Text = AnOrder.Address;
            txtTotalCost.Text = AnOrder.TotalCost.ToString();
            txtDeliveryDate.Text = AnOrder.DeliveryDate.ToString();
        }
    }

    void DisplayaOrder()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderID.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtTotalCost.Text = OrderBook.ThisOrder.TotalCost.ToString();
        txtAddress.Text = OrderBook.ThisOrder.Address.ToString();
        txtDeliveryDate.Text = OrderBook.ThisOrder.DeliveryDate.ToString();
    }
}
    