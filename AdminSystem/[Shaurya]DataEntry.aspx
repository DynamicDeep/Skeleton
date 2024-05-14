<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Shaurya]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            color: #999;
            margin-bottom: 0px;
            display: block;
            font-size: 15px; /* Tamanho do rótulo reduzido */
            
        }
        input[type="text"],
        input[type="datetime-local"],
        input[type="file"] {
            width: calc(100% - 20px);
            padding: 5px; /* Tamanho da caixa de texto reduzido */
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
            display: block;
            margin: 0 auto;
            font-size: 12px; /* Tamanho da fonte reduzido */
        }
        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 15px; /* Tamanho do botão reduzido */
            border: none;
            border-radius: 3px;
            cursor: pointer;
            font-size: 14px; /* Tamanho da fonte do botão */
            width: calc(100% - 20px);
            display: block;
            margin: 0 auto;
        }
        input[type="submit"]:hover {
            background-color: #45a049;
        }
        .error-message {
            color: red;
            font-size: 12px;
            margin-top: 5px;
        }
    </style>
</head>
<body>
    <div class="form-container">
        <h2>Insert Book details</h2>
        <form id="book-form" action="processar_dados.php" method="POST" enctype="multipart/form-data">
            <div class="form-group">
                <label for="title">Title</label>
                <input type="text" id="title" name="title" required>
            </div>

            <div class="form-group">
                <label for="genre">Genre</label>
                <input type="text" id="genre" name="genre" required>
            </div>

            <div class="form-group">
                <label for="book_name">Book Name</label>
                <input type="text" id="book_name" name="book_name" required>
            </div>

            <div class="form-group">
                <label for="author">Author</label>
                <input type="text" id="author" name="author" required>
            </div>

            <div class="form-group">
                <label for="datetime">Data/Time</label>
                <input type="datetime-local" id="datetime" name="datetime" required>
            </div>

            <div class="form-group">
                <label for="image">Image</label>
                <input type="file" id="image" name="image" required>
            </div>

            <input type="submit" value="Submit">
            <div id="error-message" class="error-message" style="display: none;"></div>
        </form>
    </div>
</body>
</html>
