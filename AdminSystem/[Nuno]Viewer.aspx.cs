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
        if (Session["Book"] != null && Session["Genre"] != null)
        {
            clsbook Book = (clsbook)Session["Book"];
            clsGenre Genre = (clsGenre)Session["Genre"];

            Response.Write("Title: " + Book.Title + "<br/>");
            Response.Write("Author: " + Book.Author + "<br/>");
            Response.Write("Genre: " + Genre.BookGenre + "<br/>");
            Response.Write("Description:" + Book.Description + "<br/>");

            // Display image if available
            if (!string.IsNullOrEmpty(Book.ImagePath))
            {
                Response.Write("<img src='" + ResolveUrl(Book.ImagePath) + "' alt='Book Cover' /><br/>");
            }
            else
            {
                Response.Write("No image available.<br/>");
            }
        }
        else
        {
            Response.Write("No book information available.");
        }
    }
}
