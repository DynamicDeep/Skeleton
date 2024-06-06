<%@ Page Language="C#" AutoEventWireup="true" CodeFile="[Shaurya]Viewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff View</title>
    <style>
        /* Resetting default margin and padding */
body, html {
    margin: 0;
    padding: 0;
}

/* Setting a background color */
body {
    background-color: #f0f0f0;
    font-family: Arial, sans-serif; /* Using Arial font */
}

/* Centering the form */
form {
    width: 80%;
    margin: 0 auto;
    padding-top: 50px; /* Adding some space from the top */
}

/* Styling the container */
div {
    background-color: #fff;
    border-radius: 8px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Adding a subtle shadow */
    padding: 20px;
}

/* Styling the title */
h1 {
    text-align: center;
    color: #333;
}

/* Styling the form elements */
input[type="text"],
input[type="password"],
input[type="submit"] {
    width: 100%;
    padding: 10px;
    margin-bottom: 15px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box; /* Ensuring padding and border are included in the element's total width and height */
}

input[type="submit"] {
    background-color: #007bff; /* Blue submit button */
    color: #fff;
    cursor: pointer;
    transition: background-color 0.3s ease; /* Adding a smooth transition effect */
}

input[type="submit"]:hover {
    background-color: #0056b3; /* Darker blue on hover */
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
