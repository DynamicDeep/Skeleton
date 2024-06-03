<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Nuno]List.aspx.cs" Inherits="_1_List" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Visualizar Livros</title>
    <style>
        table {
            width: 100%;
            border-collapse: collapse;
        }
        th, td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        th {
            background-color: #f2f2f2;
        }
        .action-buttons button {
            padding: 5px 10px;
            margin-right: 5px;
        }
    </style>
</head>
<body>
    <h2>Lista de Livros</h2>
    <table>
        <thead>
            <tr>
                <th>Title</th>
                <th>Genre</th>
                <th>Publication Year</th>
                <th>Description</th>
                <th>Price</th>
                <th>Image</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody id="bookList">
            <asp:Literal ID="litBookList" runat="server"></asp:Literal>
        </tbody>
    </table>
</body>
</html>