<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Jagruti]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
     <asp:TextBox ID="txtOrderID" runat="server"  style="z-index: 1; left: 127px; top: 121px; position: absolute; height: 25px; width: 131px;" OnTextChanged="TextOrderId_TextChanged"></asp:TextBox>


        <br />

        <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>

        <br />
        <br />
        <asp:Label ID="lblBook" runat="server" Text="Book"></asp:Label>
        <br />
        <asp:TextBox ID="txtBook" runat="server" style="z-index: 1; left: 128px; top: 166px; position: absolute" height="25px" width="128px" OnTextChanged="TextBox2_TextChanged1"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        <br />
&nbsp;<br />
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 128px; top: 204px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 129px; top: 242px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDateofOrder" runat="server" style="z-index: 1; left: 128px; top: 276px; position: absolute" height="25px" width="128px"></asp:TextBox>
        <asp:Label ID="lblDateoforder" runat="server" Text="Date Of Order"></asp:Label>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:CheckBox ID="lblOrdercomplete" runat="server" Text="Order Complete" />
        <br />
        <br />
        <br />
        <br />
            <asp:Button ID="BtnOk" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 111px; top: 431px; position: absolute; height: 30px; bottom: 204px; width: 128px; right: 411px;" Text="OK" />
        <br />
        <br />
        <asp:Button ID="Btn2" runat="server" style="z-index: 1; left: 263px; top: 432px; position: absolute; height: 30px; width: 128px;" Text="Cancel" OnClick="Button2_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
