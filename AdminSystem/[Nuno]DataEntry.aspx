<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Nuno]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário de Inserção de Dados</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            padding: 100px;
        }
        h2 {
            color: #333;
            text-align: center;
        }
        .form-container {
            width: 400px;
            margin: 0 auto;
            background-color: #fff;
            padding: 15px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
            text-align: center; /* Center align buttons */
        }
        .form-group {
            margin-bottom: 15px;
            text-align: left; /* Align labels to the left */
        }
        label {
            color: #999;
            margin-bottom: 0px;
            display: block;
            font-size: 15px;
        }
        input[type="text"],
        input[type="datetime-local"],
        input[type="file"],
        select,
        textarea {
            width: calc(100% - 20px);
            padding: 5px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
            display: block;
            margin: 0 auto;
            font-size: 12px;
        }
        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 3px;
            cursor: pointer;
            font-size: 14px;
            width: calc(100% - 20px);
            display: block;
            margin: 0 auto;
            margin-top: 10px;
            margin-bottom: 10px;
        }
        input[type="submit"]:hover {
            background-color: #45a049;
        }
        .error-message {
            color: red;
            font-size: 12px;
            margin-top: 5px;
        }

        /* Button styles */
        .button-container {
            display: flex;
            justify-content: space-between;
            margin-top: 10px;
        }

        button, input[type="submit"] {
            flex: 1;
            background-color: #008CBA;
            color: white;
            padding: 10px 0; /* Adjust padding */
            border: none;
            border-radius: 3px;
            cursor: pointer;
            font-size: 14px;
            margin: 0 5px; /* Adjust margin for spacing */
            width: 100px; /* Fixed width for buttons */
        }

        /* Green background color for clicked Back button */
        .clicked {
            background-color: green !important;
        }

        /* Red color for Clear button on hover */
        button:hover {
            background-color: red;
        }

        /* Set height of description box */
        #description {
            height: 100px;
            display: block; 
            overflow-y: auto; 
            resize: vertical; 
            word-wrap: break-word; 
            vertical-align: top; 
        }

        
 .image 

    img {
    max-width: 10%; /* Set maximum width to ensure responsiveness */
    height: auto; /* Maintain aspect ratio */
}

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Insert Book details</h2>
            <div class="form-group">
                <label for="title">Title</label>
                <asp:TextBox ID="title" runat="server" ></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="genre">Genre</label>
                <asp:DropDownList ID="genre" runat="server" >
                    <asp:ListItem Value="" Text="Select Genre"></asp:ListItem>
                    <asp:ListItem Value="Fantasy" Text="Fantasy"></asp:ListItem>
                    <asp:ListItem Value="Science Fiction" Text="Science Fiction"></asp:ListItem>
                    <asp:ListItem Value="Mystery" Text="Mystery"></asp:ListItem>
                    <asp:ListItem Value="Romance" Text="Romance"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="author">Author</label>
                <asp:TextBox ID="author" runat="server"></asp:TextBox>
            </div>

           
         

           <div class="form-group">
               <label for="publicationYear">Publication Year</label>
               <asp:TextBox ID="publicationYear" runat="server"></asp:TextBox>
          </div>

             <div class="form-group">
                 <label for="price">Price</label>
                 <asp:TextBox ID="price" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="description">Description</label>
                <asp:TextBox ID="description" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
            </div>
<div class="form-group">
    <label for="image">Select Image:</label>
    <asp:FileUpload ID="imageUpload" runat="server" />
</div>

<div class="image-container">
    <asp:Image ID="uploadedImage" runat="server" CssClass="uploaded-image" />
</div>

            <div class="button-container"> <!-- Flex container for buttons -->
                <!-- Buttons to clear, go back, and submit -->
                <button id="clearButton" onclick="clearForm()">Clear</button>
                <asp:Button ID="backButton" runat="server" Text="Back" OnClick="backButton_Click" />
                <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
            </div>
            
            <div id="error-message" class="error-message" style="display: none;"></div>
        </div>
    </form>

    <!-- Scripts  -->
    <script>
        function clearForm() {
            document.getElementById("form1").reset();
        }
    </script>
</body>
</html>
