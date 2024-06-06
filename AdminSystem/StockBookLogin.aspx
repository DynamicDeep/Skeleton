<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockBookLogin.aspx.cs" Inherits="StockBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login Page </title>
     <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            background: #000;
            font-family: 'Poppins', sans-serif;
        }
        .container {
            position: relative;
            width: 100%;
            max-width: 400px;
            padding: 40px;
            background: rgba(255, 255, 255, 0.1);
            box-shadow: 0 15px 25px rgba(0, 0, 0, 0.5);
            border-radius: 10px;
            text-align: center;
        }
        .login-box {
            position: relative;
            padding: 20px;
        }
        .login-box h2 {
            margin-bottom: 30px;
            color: #fff;
        }
        .user-box {
            position: relative;
        }
        .user-box input {
            width: 100%;
            padding: 10px 0;
            font-size: 16px;
            color: #fff;
            margin-bottom: 30px;
            border: none;
            border-bottom: 1px solid #fff;
            background: transparent;
            outline: none;
        }
        .user-box label {
            position: absolute;
            top: 0;
            left: 0;
            padding: 10px 0;
            font-size: 16px;
            color: #fff;
            pointer-events: none;
            transition: 0.5s;
        }
        .user-box input:focus ~ label,
        .user-box input:valid ~ label {
            top: -20px;
            left: 0;
            color: #03e9f4;
            font-size: 12px;
        }
        .btn {
            position: relative;
            display: inline-block;
            padding: 10px 20px;
            color: #03e9f4;
            font-size: 16px;
            text-decoration: none;
            text-transform: uppercase;
            overflow: hidden;
            transition: 0.5s;
            margin-top: 40px;
            letter-spacing: 4px;
            border: none;
            background: transparent;
            cursor: pointer;
        }
        .btn:hover {
            background: #03e9f4;
            color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 5px #03e9f4,
                        0 0 25px #03e9f4,
                        0 0 50px #03e9f4,
                        0 0 100px #03e9f4;
        }
        .btn span {
            position: absolute;
            display: block;
        }
        .btn span:nth-child(1) {
            top: 0;
            left: -100%;
            width: 100%;
            height: 2px;
            background: linear-gradient(90deg, transparent, #03e9f4);
            animation: btn-anim1 1s linear infinite;
        }
        @keyframes btn-anim1 {
            0% {
                left: -100%;
            }
            50%, 100% {
                left: 100%;
            }
        }
        .btn span:nth-child(2) {
            top: -100%;
            right: 0;
            width: 2px;
            height: 100%;
            background: linear-gradient(180deg, transparent, #03e9f4);
            animation: btn-anim2 1s linear infinite;
            animation-delay: 0.25s;
        }
        @keyframes btn-anim2 {
            0% {
                top: -100%;
            }
            50%, 100% {
                top: 100%;
            }
        }
        .btn span:nth-child(3) {
            bottom: 0;
            right: -100%;
            width: 100%;
            height: 2px;
            background: linear-gradient(270deg, transparent, #03e9f4);
            animation: btn-anim3 1s linear infinite;
            animation-delay: 0.5s;
        }
        @keyframes btn-anim3 {
            0% {
                right: -100%;
            }
            50%, 100% {
                right: 100%;
            }
        }
        .btn span:nth-child(4) {
            bottom: -100%;
            left: 0;
            width: 2px;
            height: 100%;
            background: linear-gradient(360deg, transparent, #03e9f4);
            animation: btn-anim4 1s linear infinite;
            animation-delay: 0.75s;
        }
        @keyframes btn-anim4 {
            0% {
                bottom: -100%;
            }
            50%, 100% {
                bottom: 100%;
            }
        }
        .error-message {
            color: #f00;
            font-size: 14px;
            margin-top: 20px;
            display: none;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server">
        <div class="container">
            <div class="login-box">
                <h2>Login</h2>
                <div class="user-box">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"  required="required"></asp:TextBox>
                    <label for="txtUsername">Username</label>
                </div>
                <div class="user-box">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"  required="required"></asp:TextBox>
                    <label for="txtPassword">Password</label>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn" OnClick="btnLogin_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="error-message" />
            </div>
        </div>
    </form>
</body>
</html>
