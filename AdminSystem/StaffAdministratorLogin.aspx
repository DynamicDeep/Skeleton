<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffAdministratorLogin.aspx.cs" Inherits="StaffAdministratorLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrator Login</title>
    <style>
        body {
            background-color: #2c3e50;
            color: #ecf0f1;
            font-family: Arial, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-container {
            background-color: #34495e;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            width: 300px;
            text-align: center;
        }
        .login-container h2 {
            margin-bottom: 20px;
        }
        .input-group {
            margin-bottom: 15px;
        }
        .input-group label {
            display: block;
            margin-bottom: 5px;
            text-align: left;
        }
        .input-group input {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 10px;
            border-radius: 5px;
            box-sizing: border-box;
        }
        .login-button {
            background-color: #1abc9c;
            color: #ecf0f1;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            width: 100%;
        }
        .login-button:hover {
            background-color: #16a085;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Login</h2>
            <div class="input-group">
                <label for="username">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Username<asp:TextBox ID="txtUsername" runat="server" Width="268px"></asp:TextBox>
                </label>
&nbsp;</div>
            <div class="input-group">
                <label for="password">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="266px"></asp:TextBox>
                </label>
                <br />
                <br />
                <asp:Button ID="btnLogin" runat="server" BackColor="#66FF33" Height="54px" OnClick="btnLogin_Click" Text="Login" Width="105px" />
&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" BackColor="Red" Height="52px" Text="Cancel" Width="114px" OnClick="btnCancel_Click" />
                <asp:Label ID="lblError" runat="server" CssClass="error-message" />
                <br />
                <br />
               </div>
        </div>
    </form>
</body>
</html>
