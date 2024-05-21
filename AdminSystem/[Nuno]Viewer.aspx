<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Nuno]Viewer.aspx.cs" Inherits="AdminSystem._1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Store</title>
    <style>
        .store {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
        }
        .book-item {
            width: 150px;
            border: 1px solid #ccc;
            padding: 10px;
            text-align: center;
        }
        .book-item img {
            max-width: 100%;
            height: auto;
        }
        .book-title {
            font-size: 1em;
            margin: 10px 0;
        }
        .book-author, .book-genre, .book-price {
            font-size: 0.9em;
            color: #666;
        }
        .book-description {
            white-space: pre-wrap; /* Preserve line breaks and spaces */
            word-wrap: break-word; /* Break long words */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="store">
            <asp:Repeater ID="rptBooks" runat="server">
                <ItemTemplate>
                    <div class="book-item">
                      <asp:Image ID="imgBookCover" runat="server" ImageUrl="http://exemplo.com/caminho/da/imagem.jpg" AlternateText="Book Cover" />

                        <div class="book-title"><%# Eval("Title") %></div>
                        <div class="book-author">Author: <%# Eval("Author") %></div>
                        <div class="book-genre">Genre: <%# Eval("Genre") %></div>
                        <div class="book-price">Price: £<%# Eval("Price") %> </div>
                        <div class="book-description">Description: <%# Eval("Description") %></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>