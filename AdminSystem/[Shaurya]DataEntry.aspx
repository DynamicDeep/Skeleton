<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Shaurya]DataEntry.aspx.cs" Inherits="_1_DataEntry" %> 

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Registration</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f7f7f7;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 50%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            margin-top: 50px;
        }
        h2 {
            text-align: center;
            color: #333;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            color: #333;
        }
        .form-group input, .form-group select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .btn-group {
            text-align: center;
            margin-top: 20px;
        }
        .btn {
            padding: 10px 20px;
            margin: 5px;
            border: none;
            color: #fff;
            cursor: pointer;
            border-radius: 4px;
        }
        .btn-clear {
            background-color: #f39c12;
        }
        .btn-no-submit {
            background-color: #e74c3c;
        }
        .checkbox {
            display: flex;
            align-items: center;
            margin-top: 10px;
        }
        .checkbox input {
            margin-right: 5px;
        }
        .error-label {
            color: red;
            text-align: center;
            margin-top: 10px;
        }
        .btnSubmit {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Staff Registration</h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Staff ID:"></asp:Label>
            </p>
            <div class="form-group">
                &nbsp;<asp:TextBox ID="txtStaffId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStaffName">
                <asp:Label ID="Label2" runat="server" Text="Staff Name:"></asp:Label>
                </label>&nbsp;<asp:TextBox ID="txtStaffName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStaffName">
                <asp:Label ID="Label3" runat="server" Text="Staff Address:"></asp:Label>
                </label>&nbsp;<asp:TextBox ID="txtStaffAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStaffName">
                <asp:Label ID="Label4" runat="server" Text="Staff Email:"></asp:Label>
                </label>&nbsp;<asp:TextBox ID="txtStaffEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStaffName">
                <asp:Label ID="Label5" runat="server" Text="Staff Phone Number:"></asp:Label>
                </label>&nbsp;<asp:TextBox ID="txtStaffPhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtStaffName">
                <asp:Label ID="Label6" runat="server" Text="Staff Position:"></asp:Label>
                </label>
&nbsp;<asp:TextBox ID="txtStaffPosition" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="checkbox">
                <asp:CheckBox ID="chkAgree" runat="server" OnCheckedChanged="chkAgree_CheckedChanged" />
                <label for="chkAgree">
                I agree to the terms and conditions</label></div>
            <div class="btn-group">
                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-clear" OnClick="btnClear_Click" />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btnSubmit" OnClick="btnSubmit_Click" BackColor="#33CC33" Height="34px" Width="92px" />
                <asp:Button ID="Button1" runat="server" BackColor="#CC6699" Height="36px" OnClick="Button1_Click" Text="Find" Width="77px" />
                <asp:Button ID="btnReturnM" runat="server" BackColor="#FFFF66" Height="36px" OnClick="btnReturnM_Click" Text="MainMenu" Width="143px" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
        </div>
    </form>
</body>
</html>
