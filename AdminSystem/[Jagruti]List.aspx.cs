using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected ListBox lstOrderList; // Assuming lstOrderList is a ListBox
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        // if this is the first time the page is displayed
        if (!IsPostBack == false)
        {
            //if this is the note a new record
            if (OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("[Jagruti]DataEntry.aspx");

    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        // a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
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









