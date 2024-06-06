<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: 'Poppins', sans-serif;
            background: #000;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .menu-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
            gap: 20px;
            width: 80%;
            max-width: 800px;
            margin: 0 auto;
        }
        .menu-button {
            padding: 20px;
            background: rgba(255, 255, 255, 0.1);
            color: #fff;
            text-transform: uppercase;
            text-align: center;
            border: 2px solid #03e9f4;
            border-radius: 10px;
            cursor: pointer;
            transition: background 0.3s, color 0.3s, transform 0.3s;
        }
        .menu-button:hover {
            background: #03e9f4;
            color: #fff;
            transform: scale(1.05);
        }
        .menu-button span {
            position: relative;
            display: block;
            font-size: 18px;
            letter-spacing: 2px;
        }
        @media (max-width: 600px) {
            .menu-button {
                padding: 15px;
                font-size: 16px;
            }
        }

         .heading-text{
        display: flex;
        justify-content: center;
        color: #03e9f4;
        font-weight: 700;
        font-size: 4rem;
    </style>
</head>
<body>
   <form id="form1" runat="server">
       <asp:Label ID="headingText" runat="server" CssClass="heading-text" Text="Main Menu" />
        <div class="menu-container">
            <asp:Button ID="StaffButton" runat="server" CssClass="menu-button" Text="Staff" OnClick="StaffButton_Click" />
            <asp:Button ID="CustomerButton" runat="server" CssClass="menu-button" Text="Customer" OnClick="CustomerButton_Click" />
            <asp:Button ID="StockButton" runat="server" CssClass="menu-button" Text="Stock" OnClick="StockButton_Click" />
            <asp:Button ID="SupplierButton" runat="server" CssClass="menu-button" Text="Supplier" OnClick="SupplierButton_Click" />
            <asp:Button ID="OrderButton" runat="server" CssClass="menu-button" Text="Order" OnClick="OrderButton_Click" />
            <asp:Button ID="BookButton" runat="server" CssClass="menu-button" Text="Book" OnClick="BookButton_Click" />
        </div>
    </form>
</body>
</html>
