using System;
using System.Text;
using ClassLibrary; // Ensure this is the correct namespace for clsBookCollection and clsGenreCollection

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (!IsPostBack)
        {
            // Update the list box
            DisplayBooks();
        }
    }

    void DisplayBooks()
    {
        // Create an instance of the book collection
        clsBookCollection Books = new clsBookCollection();
        // Create an instance of the genre collection
        clsGenresCollection Genres = new clsGenresCollection();

        // Build the HTML for the table rows
        StringBuilder html = new StringBuilder();

        foreach (var book in Books.BookList)
        {
            // Get the genre associated with the book by its ID
            string genre = GetGenreByBookId(book.BookId, Genres);

            // Add a new row to the table for each book
            html.Append("<tr>");
            html.AppendFormat("<td>{0}</td>", book.Title); // Book title
            html.AppendFormat("<td>{0}</td>", genre); // Associated genre
            html.AppendFormat("<td>{0:dd/MM/yyyy}</td>", book.PublicationYear); // Publication year formatted
            html.AppendFormat("<td>{0}</td>", book.Description); // Book description
            html.AppendFormat("<td>{0:C}</td>", book.Price); // Price formatted as currency
            html.AppendFormat("<td><img src='{0}' alt='Book Image' style='height:50px;' /></td>", book.ImagePath); // Book image
            html.Append("<td>");
            html.AppendFormat("<button onclick='editBook({0})'>Edit</button>", book.BookId); // Button to edit the book
            html.AppendFormat("<button onclick='deleteBook({0})'>Delete</button>", book.BookId); // Button to delete the book
            html.Append("</td>");
            html.Append("</tr>");
        }

        // Assign the generated HTML to the Literal control
        litBookList.Text = html.ToString();
    }

    string GetGenreByBookId(int bookId, clsGenresCollection genres)
    {
        // Find the genre associated with the book by its ID
        foreach (var genre in genres.GenreList)
        {
            if (genre.BookId == bookId)
            {
                return genre.BookGenre; // Return the corresponding genre
            }
        }
        // Return a default value if the genre is not found
        return "Unknown Genre";
    }

}
