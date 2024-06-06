<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerAdd.aspx.cs" Inherits="CustomerAdd" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Customer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name:" />
            <asp:TextBox ID="txtCustomerName" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblEmailaddress" runat="server" Text="Email Address:" />
            <asp:TextBox ID="txtEmailaddress" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:" />
            <asp:TextBox ID="txtPhoneNumber" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblRegistrationDate" runat="server" Text="Registration Date:" />
            <asp:TextBox ID="txtRegistrationDate" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblDateofbirth" runat="server" Text="Date of Birth:" />
            <asp:TextBox ID="txtDateofbirth" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblGender" runat="server" Text="Gender:" />
            <asp:TextBox ID="txtGender" runat="server" />
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
