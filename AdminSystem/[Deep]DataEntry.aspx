<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Deep]DataEntry.aspx.cs" Inherits="_1_DataEntry" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Stock</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            border: border-box;
            font-family: Georgia, 'Times New Roman', Times, serif;
        }

        .heading {
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

        .Hero-part {
            height: 550px;
            width: 80%;
            position: relative;
            left: 150px;
            top: 100px;
            background-color: #333;
            border-radius: 15px;
        }



        .input-box {
            margin-top: 30px;
            margin-left: 30px;
            position: relative;
            top: 30px;
            left: 370px;
        }

            .input-box input {
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


        .input-box label {
            color: #fff;
        }


        .Order-btn, .Find-btn {
            margin-top: 70px;
            margin-left: 30px;
            position: relative;
            top: 30px;
            left: 370px;
            height: 40px;
            width: 20%;
            font-size: 15px;
            font-weight: 600;
        }

        .label {
            color: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="heading">Stock Management System</div>
        </header>

        <main>
            <div class="Hero-part">
                <asp:Panel ID="Panel1" runat="server">
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelStockId" runat="server" Text="Stock ID:"></asp:Label>
                        <asp:TextBox ID="TextBoxStockId" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelBookNo" runat="server" Text="Book Number:"></asp:Label>
                        <asp:TextBox ID="TextBoxBookNo" runat="server" placeholder="Enter Book Number here!"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelQuantity" runat="server" Text="Quantity: "></asp:Label>
                        <asp:TextBox ID="TextBoxQuantity" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="input-box input">
                        <asp:Label class="label" ID="LabelDateAdded" runat="server" Text="Date: "></asp:Label>
                        <asp:TextBox ID="TextBoxDateAdded" runat="server"></asp:TextBox>
                    </div>
            </div>
            <div class="input-box input">
                <asp:Label class="label" ID="LabelStockName" runat="server" Text="StockName: "></asp:Label>
                <asp:TextBox ID="TextStockName" runat="server"></asp:TextBox>
            </div>
            <div class="input-box input">
                <asp:Label class="label" ID="LabelSupplierId" runat="server" Text="Supplier ID: "></asp:Label>
                <asp:TextBox ID="TextBoxSupplierID" runat="server"></asp:TextBox>
            </div>

            <asp:Button ID="ButtonOrder" runat="server" Text="Order" CssClass="Order-btn" OnClick="ButtonOrder_Click" />
            <asp:Button ID="ButtonFind" runat="server" Text="Find" CssClass="Find-btn" OnClick="ButtonFind_Click" />

            <asp:Label class="label" ID="LabelError" runat="server"></asp:Label>
            </asp:Panel>
            </div>
        </main>
    </form>
</body>
</html>
