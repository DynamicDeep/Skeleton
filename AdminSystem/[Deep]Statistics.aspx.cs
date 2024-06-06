using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsstock = new clsStock();
        //retrieve data from the database
        DataTable dT = clsstock.StatisticsGroupedByBookID();
        //upload dT into GridView
        GridViewStGroupByBookID.DataSource = dT;
        GridViewStGroupByBookID.DataBind();

        //change the header of the first column
        GridViewStGroupByBookID.HeaderRow.Cells[0].Text = " Total ";

        //retrieve the data from the database
        dT = clsstock.StatisticsGroupedBySupplierID();
        //upload dt into GridView
        GridViewStGroupBySupplierID.DataSource = dT;
        GridViewStGroupBySupplierID.DataBind();

        GridViewStGroupBySupplierID.HeaderRow.Cells[0].Text = " Total ";
    } 
}