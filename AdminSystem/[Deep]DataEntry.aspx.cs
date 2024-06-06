using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //variable to store the primary key with page level scope
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Stock to be processed 
        StockId = Convert.ToInt32(Session["StockId"]);
        if(IsPostBack == false)
        {
            //if this is the not a new record
            if(StockId != 1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    protected void ButtonOrder_Click(object sender, EventArgs e)
    {
        

        //create a new instance of clsAddress
        clsStock aStock = new clsStock();

        //create a new instance of clsStockId
        aStock.stockId = int.Parse(TextBoxStockId.Text);

        //capture the BookId 
        int BookId = int.Parse(TextBoxBookNo.Text);

        //capture the Quantity
        int Quantity = int.Parse(TextBoxQuantity.Text);

        //capture the date
        DateTime DateAdded = DateTime.Parse(TextBoxDateAdded.Text);

        //capture the supplier Id
        aStock.SupplierId = int.Parse(TextBoxSupplierID.Text);

        string Error = "";
        //validate the data 
        Error = aStock.Valid(BookId, Quantity, TextBoxDateAdded.Text);
        if(Error == "")
        {
            //capture the Stock Id
            aStock.stockId = StockId; 
            aStock.BookId = BookId;
            aStock.Quantity = Quantity;
            aStock.DateAdded = DateAdded;
            //create a new instance of the address collection 
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. StockId = -1 then add the data
            if(StockId == -1)
            {
                // set the ThisAddress proprty
                StockList.ThisStock = aStock;
                //add the new record 
                StockList.Add();
            }

            //otherwise it must be an update 
            else
            {
                //find the record to update 
                StockList.ThisStock.Find(StockId);
                //set the ThisStock property 
                StockList.ThisStock = aStock;
                //Update the record 
                StockList.Update();
            }
            
            //redirect back to the list page 
            Response.Redirect("[Deep]List.aspx");
        }
        else
        {
            //display the error message 
            LabelError.Text = Error;
        }

       
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class 
        clsStock aStock = new clsStock();
        //create a variable to store the primary key 
        Int32 StockId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        StockId = Convert.ToInt32(TextBoxStockId.Text);
        //get the primary key entered by the user 
        Found = aStock.Find(StockId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            TextBoxBookNo.Text = aStock.BookId.ToString();
            TextBoxDateAdded.Text = aStock.DateAdded.ToShortDateString();
            TextBoxQuantity.Text = aStock.Quantity.ToString();
            TextBoxSupplierID.Text = aStock.SupplierId.ToString();

        }

       
    }

    void DisplayStock()
    {
        //create an instance of the Stock Book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update 
        StockBook.ThisStock.Find(StockId);
        //display the data for the record 
        TextBoxStockId.Text = StockBook.ThisStock.stockId.ToString();
        TextBoxBookNo.Text = StockBook.ThisStock.BookId.ToString();
        TextBoxQuantity.Text = StockBook.ThisStock.Quantity.ToString();
        TextBoxDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        TextBoxSupplierID.Text = StockBook.ThisStock.SupplierId.ToString();
    }
}