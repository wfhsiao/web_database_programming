<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyBulletedList.aspx.cs" Inherits="MyBulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url" DisplayMode="HyperLink">
        </asp:BulletedList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/links.xml"></asp:XmlDataSource>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url">
        </asp:CheckBoxList>
    
    </div>
    </form>
</body>
</html>
