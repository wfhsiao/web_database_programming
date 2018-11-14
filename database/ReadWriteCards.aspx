<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReadWriteCards.aspx.cs" Inherits="ReadWriteCards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="產生資料" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="shape" HeaderText="shape" SortExpression="shape" />
                <asp:BoundField DataField="point" HeaderText="point" SortExpression="point" />
                <asp:BoundField DataField="score" HeaderText="score" SortExpression="score" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [cards]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
