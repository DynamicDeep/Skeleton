using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void FindButton_Click(object sender, EventArgs e)
    {
        // Your logic for handling the click event of the Add button
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        // Create instances of clsbook and clsGenre
        clsbook Book = new clsbook();
        clsGenres Genre = new clsGenres();

        // Assign values from TextBoxes and DropDownList to Book properties
        Book.Title = title.Text;
        Book.Author = author.Text;

        // Attempt to convert PublicationYear and Price to DateTime and Decimal
        DateTime publicationYearValue;
        if (DateTime.TryParse(publicationYear.Text, out publicationYearValue))
        {
            Book.PublicationYear = publicationYearValue;
        }
        else
        {
            Book.PublicationYear = DateTime.MinValue;
        }

        decimal priceValue;
        if (Decimal.TryParse(price.Text, out priceValue))
        {
            Book.Price = priceValue;
        }
        else
        {
            Book.Price = 0;
        }

        Book.Description = description.Text;

        // Assign values to Genre properties
        Genre.BookGenre = genre.SelectedValue;

        // Store instances in Session
        Session["Book"] = Book;
        Session["Genre"] = Genre;

        // Redirect to Viewer.aspx page
        Response.Redirect("[Nuno]Viewer.aspx");
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        // Seu código para lidar com o clique do botão de voltar
    }
}