using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    // Assuming lstOrderList is a ListBox
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }


    void DisplayOrders()
    {
        // create an instance of the Order collection
        clsOrderCollection Order = new clsOrderCollection();

        // set the data source to the list of Orders in the collection
        lstOrderlist.DataSource = Order.OrderList;

        // set the name of the primary key
        lstOrderlist.DataValueField = "OrderId";

        // set the data field to display
        lstOrderlist.DataTextField = "Address";

        // bind the data to the list
        lstOrderlist.DataBind();
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        {
            //variable to store the primary key value of the record to be edited
            Int32 OrderId;
            // a record has been selected from the list
            if (lstOrderlist.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                OrderId = Convert.ToInt32(lstOrderlist.SelectedValue);
                //store the data in the session object
                Session["OrderId"] = OrderId;
                Response.Redirect("[Jagruti]ConfirmDelete.aspx");
            }
            else    //if no record has been selected
            {
                lblError.Text = "Please select a record from the list to edit";
            }
        }
    }
    protected void BtnApplFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retrieve the value of post code form the presentatopn layer
        AnOrder.ReportByAddress(txtFilter.Text);
        //set the data source to the list of address in collection
        lstOrderlist.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderlist.DataValueField = "AnorderList";
        //set the name of the field of display
        lstOrderlist.DataTextField = "Name";
        //bind the data to list
        lstOrderlist.DataBind();

    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set and empty string
        AnOrder.ReportByAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data sourc to the list of address in the collection
        lstOrderlist.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderlist.DataValueField = "OrderId";
        lstOrderlist.DataTextField = "Address";
        //bind the data to the list
        lstOrderlist.DataBind();

    }

    protected void BtnFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsOrderCollection Anorder = new clsOrderCollection();
        //retrieve the value of address from the presentation layer
        Anorder.ReportByAddress(txtFilter.Text);
        //set the data source to the list of addresses in collection
        lstOrderlist.DataSource = Anorder.OrderList;
        //set the name of the primary to display
        lstOrderlist.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderlist.DataTextField = "Address";
        //bind the data to the list
        lstOrderlist.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("[Jagruti]DataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        // a record has been selected from the list
        if (lstOrderlist.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderlist.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            Response.Redirect("[Jagruti]DataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}











