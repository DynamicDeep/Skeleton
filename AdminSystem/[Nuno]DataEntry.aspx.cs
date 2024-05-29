using System;
using System.IO;
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
        // Criar novas instâncias de clsbook e clsGenres
        clsbook Book = new clsbook();
        clsGenres Genre = new clsGenres();

        // Capturar os dados do formulário
        string Title = title.Text;
        string Author = author.Text;
        string PublicationYear = publicationYear.Text;
        string Price = price.Text;
        string Description = description.Text;
        string ImagePath = imageUpload.FileName;

        // Capturar os dados do gênero
        string BookGenre = genre.SelectedValue;

        // Variável para armazenar mensagens de erro
        string Error = "";

        // Validar os dados do livro
        Error = Book.Valid(Title, Author, PublicationYear, Price, Description, ImagePath);

        // Se não houver erro, validar os dados do gênero
        if (Error == "")
        {
            Error = Genre.Valid(BookGenre);
        }

        // Verificar se há erros
        if (Error == "")
        {
            try
            {
                // Capturar os dados do livro
                Book.Title = Title;
                Book.Author = Author;
                Book.PublicationYear = Convert.ToDateTime(PublicationYear);
                Book.Price = Convert.ToDecimal(Price);
                Book.Description = Description;

                // Verificar e salvar o caminho da imagem
                if (imageUpload.HasFile)
                {
                    try
                    {
                        string fileName = Path.GetFileName(imageUpload.FileName);
                        string imagePath = "~/Images/" + fileName;

                        // Obter o caminho físico no servidor
                        string serverPath = Server.MapPath(imagePath);

                        // Verificar se o diretório existe, se não, criar
                        string directory = Path.GetDirectoryName(serverPath);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        // Salvar a imagem carregada
                        imageUpload.SaveAs(serverPath);

                        // Atualizar o caminho da imagem na instância do livro
                        Book.ImagePath = imagePath;
                    }
                    catch (Exception ex)
                    {
                        // Tratar quaisquer exceções (e.g., diretório não encontrado, problemas de permissão)
                        // Registrar o erro ou exibir uma mensagem de erro para o usuário
                        lblError.Text = "Ocorreu um erro ao salvar a imagem: " + ex.Message;
                        return; // Interromper a execução se houver um erro ao salvar a imagem
                    }
                }
                else
                {
                    // Caso não haja imagem carregada, definir um caminho de imagem padrão
                    Book.ImagePath = "~/Images/default.png";
                }

                // Capturar os dados do gênero
                Genre.BookGenre = BookGenre;

                // Armazenar instâncias na Session
                Session["Book"] = Book;
                Session["Genre"] = Genre;

                // Redirecionar para a página de visualização se tudo estiver correto
                Response.Redirect("[Nuno]Viewer.aspx");
            }
            catch (FormatException ex)
            {
                lblError.Text = "Erro ao converter os dados: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblError.Text = "Ocorreu um erro: " + ex.Message;
            }
        }
        else
        {
            // Exibir a mensagem de erro
            lblError.Text = Error;
        }
    }



    protected void backButton_Click(object sender, EventArgs e)
    {
        // Your code for handling the click event of the back button
    }
}
