<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Shaurya]ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Delete</title>
    <style>
        body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #f8f9fa;
}

.container {
    text-align: center;
    background-color: #fff;
    padding: 20px;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.buttons {
    margin-top: 20px;
}

button {
    padding: 10px 20px;
    margin: 0 10px;
    border: none;
    border-radius: 4px;
    font-size: 16px;
    cursor: pointer;
}

button.yes {
    background-color: #d9534f;
    color: #fff;
}

button.no {
    background-color: #5bc0de;
    color: #fff;
}

button.yes:hover {
    background-color: #c9302c;
}

button.no:hover {
    background-color: #31b0d5;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="container">
        <p>Are you sure you want to delete the record?</p>
            <div class="buttons">
                <asp:Button ID="btnYes" runat="server" BackColor="#FF9933" OnClick="btnYes_Click" Text="Yes" />
&nbsp;
                <asp:Button ID="btnNo" runat="server" BackColor="Yellow" Height="48px" OnClick="btnNo_Click" Text="No" Width="72px" />
        </div>
    </div>
        </div>
    </form>
</body>
</html>
