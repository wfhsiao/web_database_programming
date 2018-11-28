<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FilteringWordsWithInitials.aspx.cs" Inherits="FilteringWordsWithInitials" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="word" DataValueField="word">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" SelectCommand="SELECT DISTINCT left([word],1) as [word] FROM [gept_words] order by [word]"></asp:SqlDataSource>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="沒有資料錄可顯示。" ForeColor="Black" GridLines="Vertical" OnDataBound="GridView1_DataBound">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:HyperLinkField DataNavigateUrlFields="word" DataNavigateUrlFormatString="https://www.google.com.tw/search?q={0}" DataTextField="word" HeaderText="word" />
                <asp:BoundField DataField="ch_explanation" HeaderText="ch_explanation" SortExpression="ch_explanation" />
                <asp:BoundField DataField="sentence" HeaderText="sentence" SortExpression="sentence" />
                <asp:BoundField DataField="level" HeaderText="level" SortExpression="level" />
                <asp:BoundField DataField="frequency" HeaderText="frequency" SortExpression="frequency" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" DeleteCommand="DELETE FROM [gept_words] WHERE [Id] = @Id" InsertCommand="INSERT INTO [gept_words] ([word], [ch_explanation], [sentence], [sno], [level], [frequency], [weight]) VALUES (@word, @ch_explanation, @sentence, @sno, @level, @frequency, @weight)" SelectCommand="SELECT [Id], [word], [ch_explanation], [sentence], [sno], [level], [frequency], [weight] FROM [gept_words] WHERE ([word] like  @word +'%')" UpdateCommand="UPDATE [gept_words] SET [word] = @word, [ch_explanation] = @ch_explanation, [sentence] = @sentence, [sno] = @sno, [level] = @level, [frequency] = @frequency, [weight] = @weight WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="word" Type="String" />
                <asp:Parameter Name="ch_explanation" Type="String" />
                <asp:Parameter Name="sentence" Type="String" />
                <asp:Parameter Name="sno" Type="String" />
                <asp:Parameter Name="level" Type="Double" />
                <asp:Parameter Name="frequency" Type="Double" />
                <asp:Parameter Name="weight" Type="Double" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="word" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="word" Type="String" />
                <asp:Parameter Name="ch_explanation" Type="String" />
                <asp:Parameter Name="sentence" Type="String" />
                <asp:Parameter Name="sno" Type="String" />
                <asp:Parameter Name="level" Type="Double" />
                <asp:Parameter Name="frequency" Type="Double" />
                <asp:Parameter Name="weight" Type="Double" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>

    </form>
</body>
</html>
