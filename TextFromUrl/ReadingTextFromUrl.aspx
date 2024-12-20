﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReadingTextFromUrl.aspx.cs" Inherits="ReadingTextFromUrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="匯入資料" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="刪除所有資料" />
        <br />
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="50px" Width="443px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <FieldHeaderStyle Width="120px" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:TemplateField HeaderText="sentence" SortExpression="sentence">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Width="98%" TextMode="MultiLine" Text='<%# Bind("sentence") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("sentence") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("sentence") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="a" HeaderText="a" SortExpression="a" />
                <asp:BoundField DataField="b" HeaderText="b" SortExpression="b" />
                <asp:BoundField DataField="c" HeaderText="c" SortExpression="c" />
                <asp:BoundField DataField="d" HeaderText="d" SortExpression="d" />
                <asp:BoundField DataField="answer" HeaderText="answer" SortExpression="answer" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [phrases]" DeleteCommand="delete from [phrases] where [id]=@id" InsertCommand="insert into [phrases] values(@sentence, @a, @b, @c, @d, @answer)" UpdateCommand="update [phrases] set [sentence]=@sentence, [a]=@a, [b]=@b, [c]=@c, [d]=@d, [answer]=@answer 
where [id]=@id">
            <DeleteParameters>
                <asp:Parameter Name="id" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="sentence" />
                <asp:Parameter Name="a" />
                <asp:Parameter Name="b" />
                <asp:Parameter Name="c" />
                <asp:Parameter Name="d" />
                <asp:Parameter Name="answer" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="sentence" />
                <asp:Parameter Name="a" />
                <asp:Parameter Name="b" />
                <asp:Parameter Name="c" />
                <asp:Parameter Name="d" />
                <asp:Parameter Name="answer" />
                <asp:Parameter Name="id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
