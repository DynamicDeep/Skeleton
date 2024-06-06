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
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();    

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate it's a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("[Deep]DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockId;
        //if a record has been selected from the list 
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key values of the record to edit
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in th session object 
            Session["StockId"]=StockId;
            //redirect to the edit page 
            Response.Redirect("[Deep]DataEntry.aspx");
        }
        else //if no record has been selected 
        {
            lblError.Text = "please select a record from the list to edit ";
        }
    }
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted 
        Int32 StockId;
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the session object 
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object 
            Session["StockId"] = StockId;
            //redirect to the delete page 
            Response.Redirect("[Deep]ConfirmDelete.aspx");
        }
        else //if no record has been selected 
        {
            //display an error message 
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByStockName(TextBoxFilter.Text);
        lstStockList.DataSource = aStock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByStockName("");
        TextBoxFilter.Text = "";
        lstStockList.DataSource= aStock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }
}