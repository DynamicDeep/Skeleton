<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Shaurya]List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of Staff Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="630px" Width="1297px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="EDIT" />
&nbsp;<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
