using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        // Redireciona para a página desejada
        Response.Redirect("[Nuno]Viewer.aspx");
    }

  
    protected void submitButton_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsbook
        clsbook Book = new clsbook();

        // Assign the title from the TextBox with ID "title" to Book
        Book.Title = title.Text;

        // Store the Book object in Session
        Session["Book"] = Book;

        // Redirect to Viewer.aspx page
        Response.Redirect("[Nuno]Viewer.aspx");
    }
}