﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Jagruti]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="OrderId">
    <form id="form1" runat="server">
        <div>
            Place Order here!<br />
            <br />
        </div>
        <br />
        <br />
        <br />
        &nbsp;
     <asp:TextBox ID="txtOrderID" runat="server"  style="z-index: 1; left: 127px; top: 121px; position: absolute; height: 25px; width: 131px;"></asp:TextBox>


        <br />

        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>

        <br />
        <br />
        <asp:Label ID="lblCustomerId" runat="server" Text="CustomerId"></asp:Label>
        <br />
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 128px; top: 166px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDeliveryDate" runat="server" Text="DeliveryDate"></asp:Label>
        <br />
&nbsp;<br />
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 128px; top: 204px; position: absolute; right: 1246px;" height="25px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 129px; top: 242px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTotalCost" runat="server" style="z-index: 1; left: 128px; top: 276px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <asp:Label ID="lblTotalCost" runat="server" Text="TotalCost"></asp:Label>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:CheckBox ID="lblOrdercomplete" runat="server" Text="Order Complete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 142px; top: 338px; position: absolute; width: 46px" Text="lblError"></asp:Label>
        <br />
        <br />
        <br />
        <br />
            <asp:Button ID="BtnOk" runat="server" OnClick="BtnOK_Click" style="z-index: 1; left: 111px; top: 431px; position: absolute; height: 30px; bottom: 204px; width: 128px; right: 411px;" Text="OK" />
        <br />
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="height: 26px" Text="Find" />
        <br />
        <asp:Button ID="BtnCanel" runat="server" style="z-index: 1; left: 263px; top: 432px; position: absolute; height: 30px; width: 128px;" Text="Cancel"/>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
