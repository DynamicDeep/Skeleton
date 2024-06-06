<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Unknown]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stock</title>
    <style>
       *{
    margin: 0;
    padding: 0;
    border: border-box;
    font-family: Georgia, 'Times New Roman', Times, serif;
}

.heading{
    height: 60px;
    width: 80%;
    background-color: #333;
    color: #fff;
    border-radius: 15px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    top: 50px;
    left: 150px;
    font-size: 2rem;
}

.Hero-part{
    height: 500px;
    width: 80%;
    position: relative;
    left: 150px;
    top: 100px;
    background-color: #333;
    border-radius: 15px;
}



.input-box{
    margin-top: 30px;
    margin-left: 30px;
    position: relative;
    top: 30px;
    left: 370px;
}

.input-box input{
    height: 40px;
    width: 30%;
    background-color: transparent;
    border: 4px #fff solid;
    border-radius: 15px;
    padding-left: 10px;
    color: #fff;
    margin-left: 20px;
}

.oneLine {
    margin-left: 20px;
}


.input-box label{
   color: #fff;
}


.Add-btn, .Find-btn, .Delete-btn {
    margin-top: 70px;
    margin-left: 30px;
    position: relative;
    top: 30px;
    left: 250px;
    height: 40px;
    width: 20%;
    font-size: 15px;
    font-weight:600;
}

.label{
    color: #fff;
}






 
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="heading">Supplier Management System</div>
        </header>

        <main>
            <div class="Hero-part" id="chkActive">
                <asp:Panel ID="Panel1" runat="server">
                    <div class="input-box input">
                         <asp:Label class="label" ID="LabelSupplierID" runat="server" Text="Supplier Id:"></asp:Label>
                         <asp:TextBox ID="TextBoxSupplierId" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelName" runat="server" Text="Supplier Name:"></asp:Label>
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelContactNo" runat="server" Text="Contact No: "></asp:Label>
                        <asp:TextBox ID="TextBoxContactNo" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
                        <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelEmailId" runat="server" Text="Email ID: "></asp:Label>
                        <asp:TextBox ID="TextBoxEmailId" runat="server"></asp:TextBox>
                    </div>
                     <div class="input-box input">
                         <asp:Label class="label" ID="LabelSupplierDate" runat="server" Text="SupplierDate "></asp:Label>
                         <asp:TextBox ID="TextBoxSupplierDate" runat="server"></asp:TextBox>
                    </div>
                    
                    <asp:Button ID="ButtonAdd" runat="server" Text="Order" CssClass="Add-btn" OnClick="ButtonAdd_Click" />
                    <asp:Button ID="ButtonFind" runat="server" Text="Find" CssClass="Find-btn" OnClick="ButtonFind_Click" />
                    <asp:Button ID="ButtonDelete" runat="server" Text="Delete" CssClass="Delete-btn" OnClick="ButtonDelete_Click" />
                </asp:Panel>
                <asp:CheckBox ID="chkActive"  Text="Active" runat="server" />
            </div>
        </main>
    </form>
</body>
</html>
