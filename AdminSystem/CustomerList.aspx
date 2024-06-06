<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="False"
            DataKeyNames="CustomerID"
            OnRowEditing="gvCustomers_RowEditing"
            OnRowUpdating="gvCustomers_RowUpdating"
            OnRowCancelingEdit="gvCustomers_RowCancelingEdit"
            OnRowDeleting="gvCustomers_RowDeleting">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" ReadOnly="True" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                <asp:BoundField DataField="Emailaddress" HeaderText="Email Address" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                <asp:BoundField DataField="RegistrationDate" HeaderText="Registration Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Dateofbirth" HeaderText="Date of Birth" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer" OnClick="btnAddCustomer_Click" />
        <asp:Button ID="btnFindCustomer" runat="server" Text="Find Customer" OnClick="btnFindCustomer_Click" />
        <asp:Button ID="btnFilterCustomer" runat="server" Text="Filter Customers" OnClick="btnFilterCustomer_Click" />
    </form>
</body>
</html>
