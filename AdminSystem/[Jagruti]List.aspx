<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Jagruti]List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="lstOrderList" style="height: 601px; width: 653px">
    <form id="form1" runat="server">
    <p>
        OrderId</p>
    <p>
        &nbsp;</p>
        <p>
            <asp:ListBox ID="lstOrderlist" runat="server" style="z-index: 1; left: 10px; top: 52px; position: absolute; width: 291px; height: 103px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 75px" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 101px; top: 261px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
