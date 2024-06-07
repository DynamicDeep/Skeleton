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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="lstOrderlist" runat="server" style="z-index: 1; left: 101px; top: 19px; position: absolute; width: 291px; height: 95px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 338px; top: 239px; position: absolute; width: 63px; right: 635px; height: 30px;" Text="Add" />
            <asp:Button ID="BntEdit" runat="server" style="z-index: 1; left: 436px; top: 42px; position: absolute; width: 55px;" Text="Edit" OnClick="BtnEdit_Click" />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 258px; top: 322px; position: absolute"></asp:TextBox>
            <asp:Button ID="BtnDelete" runat="server" style="z-index: 1; left: 108px; top: 162px;  right: 927px; height: 28px;" Text="Delete" OnClick="BtnDelete_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p style="width: 211px; height: 33px">
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 164px; top: 388px; position: absolute" Text="lblError"></asp:Label>
            Enter a First Lane Of Address&nbsp;&nbsp;&nbsp;
        </p>
        <br />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
            <asp:Button ID="BtnFilter" runat="server" OnClick="BtnFilter_Click" Text="Apply Filter" Width="119px" />
        <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" style="margin-left: 88px" Text="Clear Filter" Width="125px" />
    </form>
</body>
</html>
