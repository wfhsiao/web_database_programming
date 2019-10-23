<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    
        <br />
        ----------------------------<br />
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
