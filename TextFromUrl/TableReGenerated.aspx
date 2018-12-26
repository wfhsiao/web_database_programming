<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableReGenerated.aspx.cs" Inherits="_TableReGenerated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="generate" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="delete" />
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="50px" Width="399px">
            <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <FieldHeaderStyle Width="120px" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="word" HeaderText="word" SortExpression="word" />
                <asp:BoundField DataField="ch_explanation" HeaderText="ch_explanation" SortExpression="ch_explanation" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" Width="200px" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [words]" DeleteCommand="delete from [words] where Id=@Id" InsertCommand="insert into [words] values(@word,@ch_explanation)" UpdateCommand="update [words] set [word]=@word, [ch_explanation]=@ch_explanation where [Id]=@Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="word" />
                <asp:Parameter Name="ch_explanation" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="word" />
                <asp:Parameter Name="ch_explanation" />
                <asp:Parameter Name="Id" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        <br />
        <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
    
    </div>
    </form>
</body>
</html>
