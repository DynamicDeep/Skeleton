<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerFind.aspx.cs" Inherits="CustomerFind" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Find Customer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID:" />
            <asp:TextBox ID="txtCustomerId" runat="server" />
            <asp:Button ID="btnFindCustomer" runat="server" Text="Find Customer" OnClick="btnFindCustomer_Click" />
        </div>
        <div>
            <asp:Label ID="lblResult" runat="server" Text="" />
        </div>
        <asp:Button ID="btnBack" runat="server" Text="Back to List" OnClick="btnBack_Click" />
    </form>
</body>
</html>
