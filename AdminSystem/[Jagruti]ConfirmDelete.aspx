

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Jagruti]ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    Are you sure you want to delete this record?
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" style="z-index: 1; left: 186px; top: 174px;  height: 28px; width: 39px" Text="No" />
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 75px; top: 175px; right: 598px; height: 26px" Text="Yes" />
    </form>
</body>
</html>
