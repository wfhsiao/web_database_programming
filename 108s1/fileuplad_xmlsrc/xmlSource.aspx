<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xmlSource.aspx.cs" Inherits="xmlSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource1" DataTextField="english" DataValueField="chinese" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatColumns="3">
        </asp:RadioButtonList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/words.xml"></asp:XmlDataSource>
        <br />
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    
    </div>
    </form>
</body>
</html>
