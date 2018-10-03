<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button1" defaultfocus="TextBox1">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" onfocus="this.select();"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
