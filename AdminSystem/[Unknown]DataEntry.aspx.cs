using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsSupplier aSupplier = new clsSupplier();

        //capture the Name 
        aSupplier.SupplierName = TextBoxName.Text;

        //capture the Contact
        aSupplier.ContactNo = Int32.Parse(TextBoxContactNo.Text);

        //capture the Address 
        aSupplier.SupplierAddress = TextBoxAddress.Text;

        //caputer the Email Id
        aSupplier.SupplierEmailId = TextBoxEmailId.Text;

        //store the BookId in the session object
        Session["aSupplier"] = aSupplier;

        //navigate to the view page 
        Response.Redirect("[Unknown]Viewer.aspx");
    }

    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {

    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {

    }
}