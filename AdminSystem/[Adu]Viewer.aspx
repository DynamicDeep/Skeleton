<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Adu]Viewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Information</title>
    <style>
        body {
            background-color: #f4f4f4;
            font-family: Arial, sans-serif;
        }
        .info-container {
            width: 60%;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            border-radius: 8px;
        }
        .info-group {
            margin-bottom: 15px;
        }
        .info-group label {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class="info-container">
        <h2>Customer Information</h2>
        <div id="customerInfo" runat="server"></div>
    </div>
</body>
</html>
