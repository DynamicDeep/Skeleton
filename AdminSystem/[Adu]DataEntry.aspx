<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Adu]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>
    <style>
        body {
            background-color: #f4f4f4;
            font-family: Arial, sans-serif;
        }
        .form-container {
            width: 60%;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            border-radius: 8px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .form-group input, .form-group select, .form-group button {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 16px;
        }
        .form-group .radio-group {
            display: flex;
            gap: 20px;
        }
        .form-group .radio-group input {
            width: auto;
        }
        .button-group {
            display: flex;
            justify-content: space-between;
            margin-top: 20px;
        }
        .button-group button {
            width: 48%;
            background-color: #007BFF;
            color: white;
            border: none;
            padding: 10px;
            cursor: pointer;
            border-radius: 4px;
            font-size: 16px;
        }
        .button-group button:hover {
            background-color: #0056b3;
        }
        .button-group button.clear {
            background-color: #dc3545;
        }
        .button-group button.clear:hover {
            background-color: #c82333;
        }
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .error-message {
            color: red;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Customer Data Entry</h2>
            <div class="form-group">
                <label for="txtCustomerId">Customer ID:</label>
                <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCustomerName">Customer Name:</label>
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCustomerEmail">Email Address:</label>
                <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCustomerPhone">Phone Number:</label>
                <asp:TextBox ID="txtCustomerPhone" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCustomerSubscriptionDate">Date of Subscription:</label>
                <asp:TextBox ID="txtCustomerSubscriptionDate" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCustomerDOB">Date of Birth:</label>
                <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="radioCustomerGender">Gender:</label>
                <asp:RadioButtonList ID="radioCustomerGender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="button-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="clear" />
            </div>
            <asp:Label ID="ErrorMessage" runat="server" CssClass="error-message" />
        </div>
    </form>
</body>
</html>
