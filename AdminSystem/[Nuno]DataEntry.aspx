<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Nuno]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
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
        input[type="file"] {
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

            <div class="button-container"> <!-- Flex container for buttons -->
                <!-- Buttons for clear, back, and submit -->
                <button id="clearButton" onclick="clearForm()">Clear</button>
                <button id="backButton" onclick="goBack()">Back</button>
                <input type="submit" value="Submit">
            </div>
            
            <div id="error-message" class="error-message" style="display: none;"></div>
        </form>
    </div>

    <script>
        function clearForm() {
            document.getElementById("book-form").reset();
        }

        function goBack() {
            document.getElementById("backButton").classList.add("clicked");
            window.history.back();
        }
    </script>
</body>
</html>
