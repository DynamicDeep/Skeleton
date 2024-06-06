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
        aSupplier.Name = TextBoxName.Text;

        //capture the Contact
        aSupplier.ContactNo = Int32.Parse(TextBoxContactNo.Text);

        //capture the Address 
        aSupplier.Address = TextBoxAddress.Text;

        //caputer the Email Id
        aSupplier.EmailId = TextBoxEmailId.Text;

        //caputer the Supplier Date
        aSupplier.SupplierDate = DateTime.Parse(TextBoxSupplierDate.Text);

        //caputer the Active value 
        aSupplier.Active = chkActive.Checked;

        //store the BookId in the session object
        Session["aSupplier"] = aSupplier;

        //navigate to the view page 
        Response.Redirect("[Unknown]Viewer.aspx");
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class 
        clsSupplier aSupplier = new clsSupplier();
        //create a variable to store the primary key 
        Int32 SupplierId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        SupplierId = Convert.ToInt32(TextBoxSupplierId.Text);
        //get the primary key entered by the user 
        Found = aSupplier.Find(SupplierId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            TextBoxName.Text = aSupplier.Name.ToString();
            TextBoxContactNo.Text = aSupplier.ContactNo.ToString();
            TextBoxAddress.Text = aSupplier.Address.ToString();
            TextBoxEmailId.Text = aSupplier.EmailId.ToString();
            chkActive.Text = aSupplier.Active.ToString();
            TextBoxSupplierDate.Text = aSupplier.SupplierDate.ToString();
        }
    }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {

        }


        





}

