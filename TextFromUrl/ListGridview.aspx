<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListGridview.aspx.cs" Inherits="ListGridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="TABLE_NAME" DataValueField="TABLE_NAME" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged1"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="select TABLE_NAME from INFORMATION_SCHEMA.TABLES"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource2" OnPageIndexChanging="GridView1_PageIndexChanging">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="select 3+2"></asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
