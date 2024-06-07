<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderBookLogin.aspx.cs" Inherits="OrderBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-container {
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
            box-sizing: border-box;
        }
        .login-container h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .login-container input[type="text"],
        .login-container input[type="password"] {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .login-container button {
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .login-container button:hover {
            background-color: #45a049;
        }
        .error-message {
            color: red;
            text-align: center;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
     <div class="login-container">
        <h2>Login</h2>
        <form id="loginForm" runat="server">
            <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="False"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="input" placeholder="Username" />
            <asp:TextBox ID="txtPassword" runat="server" CssClass="input" TextMode="Password" placeholder="Password" />
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button" OnClick="btnLogin_Click" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click" />
        </form>
    </div>
</body>
</html>
