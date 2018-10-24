<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyImageButton.aspx.cs" Inherits="MyImageButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
html, body, div, span, object, form, input, h1, h2, button, label, a, img
{
    -moz-user-select: none;
    -webkit-user-select: none; /* this will work for QtWebKit in future */
    -webkit-user-drag: none;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
    
    </div>
    </form>
</body>
</html>
