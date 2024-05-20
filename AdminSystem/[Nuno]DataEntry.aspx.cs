using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO; // Add this namespace for Path and Directory classes
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        // Handle the click event for the backButton here
        // For example, you can redirect the user to a previous page:
        Response.Redirect("PreviousPage.aspx");
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
            // Handle the case where input string for publication year is not in correct format
            // You can display an error message to the user or log the issue for debugging
            // For now, let's set a default value or leave it null
            Book.PublicationYear = DateTime.MinValue; // or set to null if it's a nullable DateTime
        }

        decimal priceValue;
        if (Decimal.TryParse(price.Text, out priceValue))
        {
            Book.Price = priceValue;
        }
        else
        {
            // Handle the case where input string for price is not in correct format
            // You can display an error message to the user or log the issue for debugging
            // For now, let's set a default value or leave it zero
            Book.Price = 0; // or set to null if it's a nullable Decimal
        }

        Book.Description = description.Text;

        // Assign values to Genre properties
        Genre.BookGenre = genre.SelectedValue; // Assuming there's a property 'Name' in clsGenre to store the genre name

        // Save the image path
        if (imageUpload.HasFile)
        {
            try
            {
                string fileName = Path.GetFileName(imageUpload.FileName);
                string imagePath = "~/Images/" + fileName;

                // Get the physical path on the server
                string serverPath = Server.MapPath(imagePath);

                // Check if the directory exists, if not, create it
                string directory = Path.GetDirectoryName(serverPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Save the uploaded image
                imageUpload.SaveAs(serverPath);

                // Update the image path in the session
                Book.ImagePath = imagePath;
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., directory not found, permission issues)
                // Log the error or display an error message to the user
                Response.Write("An error occurred while saving the image: " + ex.Message);
            }
        }
        else
        {
            // Handle the case where no image is uploaded
        }

        // Store instances in Session
        Session["Book"] = Book;
        Session["Genre"] = Genre;

        // Redirect to Viewer.aspx page
        Response.Redirect("[Nuno]Viewer.aspx");
    }
}
