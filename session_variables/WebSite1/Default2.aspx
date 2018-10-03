<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="TextBox1">
    <div>
    
    &nbsp;&nbsp;&nbsp;<asp:Label ID="num1" runat="server" Text="Label"></asp:Label>
        <br />
        x <asp:Label ID="num2" runat="server" Text="Label"></asp:Label>
        <br />
        -------------<br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
        <br />
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
