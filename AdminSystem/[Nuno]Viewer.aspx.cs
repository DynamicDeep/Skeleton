using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsbook
        clsbook Book = new clsbook();

        // Assign the title from the TextBox with ID "title" to Book
        Book = (clsbook)Session["Book"];


     Response.Write(Book.Title);
    }
}