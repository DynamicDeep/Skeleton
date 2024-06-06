<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerFilter.aspx.cs" Inherits="CustomerFilter" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Filter Customers</title>
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
            <asp:Label ID="lblGender" runat="server" Text="Gender:" />
            <asp:TextBox ID="txtGender" runat="server" />
        </div>
        <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
        <asp:GridView ID="gvFilteredCustomers" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" ReadOnly="True" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="Emailaddress" HeaderText="Email Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                <asp:BoundField DataField="RegistrationDate" HeaderText="Registration Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Dateofbirth" HeaderText="Date of Birth" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnBack" runat="server" Text="Back to List" OnClick="btnBack_Click" />
    </form>
</body>
</html>
