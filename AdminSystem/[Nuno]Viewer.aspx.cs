using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace AdminSystem
{
    public partial class _1Viewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Book"] != null && Session["Genre"] != null)
                {
                    clsbook book = Session["Book"] as clsbook;
                    clsGenres genre = Session["Genre"] as clsGenres;

                    if (book != null && genre != null)
                    {
                        // Check if the image exists and set a default path if it doesn't
                        string imagePath = !string.IsNullOrEmpty(book.ImagePath) ? book.ImagePath : "default-image-path.jpg";

                        // Format the price with two decimal places
                        string formattedPrice = book.Price.HasValue ? book.Price.Value.ToString("N2") : "0.00";

                        // Create a list to bind to the Repeater
                        var books = new List<dynamic>
                {
                    new
                    {
                        Title = HttpUtility.HtmlEncode(book.Title),
                        Author = HttpUtility.HtmlEncode(book.Author),
                        Genre = HttpUtility.HtmlEncode(genre.BookGenre),
                        Description = HttpUtility.HtmlEncode(book.Description),
                        ImagePath = HttpUtility.HtmlEncode(imagePath),
                        Price = formattedPrice
                    }
                };

                        rptBooks.DataSource = books;
                        rptBooks.DataBind();
                    }
                    else
                    {
                        // Display a message if book or genre information is not available
                        Response.Write("No book information available.");
                    }
                }
                else
                {
                    // Display a message if session variables are not available
                    Response.Write("No book information available.");
                }
            }
        }

    }
}