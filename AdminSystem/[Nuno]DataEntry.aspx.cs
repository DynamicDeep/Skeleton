using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Any logic that needs to run on page load
    }

    protected void FindButton_Click(object sender, EventArgs e)
    {
        // Create an instance of the clsbook class
        clsbook Book = new clsbook();

        // Tentar encontrar o registro do livro usando o BookId fornecido
        int BookId;
        if (int.TryParse(bookId.Text, out BookId)) // bookId é o ID da TextBox
        {
            if (Book.Find(BookId))
            {
                // Se o registro for encontrado, preencher os campos da interface com os dados do livro
                bookId.Text = Book.BookId.ToString();
                title.Text = Book.Title;
                author.Text = Book.Author;
                publicationYear.Text = Book.PublicationYear.ToString("yyyy-MM-dd");
                price.Text = Book.Price.ToString();
                description.Text = Book.Description;
                // Supondo que esses campos existam no seu formulário
                //bookManagementTextBox.Text = Book.BookManagement;
                uploadedImage.ImageUrl = Book.ImagePath;
            }
            else
            {
                // Se nenhum registro for encontrado, limpar os campos da interface e exibir uma mensagem de erro
                ClearFields();
                errorMessageLabel.Text = "Record Not found.";
            }
        }
        else
        {
            // Se o BookId não for um inteiro válido, exibir uma mensagem de erro
            errorMessageLabel.Text = "Please Enter a valid value.";
        }
    }
    private void ClearFields()
    {
        // Clear all the input fields
        bookId.Text = "";
        title.Text = "";
        author.Text = "";
        publicationYear.Text = "";
        price.Text = "";
        description.Text = "";
        uploadedImage.ImageUrl = "";
        // bookManagementTextBox.Text = "";
        // imagePathTextBox.Text = "";
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        // Create instances of clsbook and clsGenres
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
        // Your code for handling the click event of the back button
    }
}
