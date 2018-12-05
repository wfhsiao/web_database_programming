<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReadWriteCardsWFilters.aspx.cs" Inherits="ReadWriteCards" %>

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
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="刪除資料" OnClientClick="return confirm('Are you sure to delete all of the data?');" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="shape" DataValueField="shape" OnDataBound="DropDownList1_DataBound">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" SelectCommand="SELECT DISTINCT [shape] FROM [cards] order by [shape] desc"></asp:SqlDataSource>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" PageSize="4" OnDataBound="GridView1_DataBound" OnRowDataBound="GridView1_RowDataBound" OnRowUpdating="GridView1_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:TemplateField HeaderText="shape" SortExpression="shape">
                    <EditItemTemplate>
                        <asp:dropdownlist ID="ddlShape" runat="server">
                            <asp:ListItem>s</asp:ListItem>
                            <asp:ListItem>h</asp:ListItem>
                            <asp:ListItem>d</asp:ListItem>
                            <asp:ListItem>c</asp:ListItem>
                        </asp:dropdownlist>
                        
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblShape" runat="server" Text='<%# Bind("shape") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="point" HeaderText="point" SortExpression="point" />
                <asp:TemplateField HeaderText="picture" SortExpression="score">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("score") %>'></asp:Label>
                    </EditItemTemplate>                    
                    <ItemTemplate>
                        <asp:Image ID="Label1" runat="server" ImageUrl='<%# "poker/" + Eval("point") + Eval("shape") + ".gif" %>'></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" SelectCommand="SELECT * FROM [cards] WHERE ([shape] like @shape)" DeleteCommand="delete from [cards] where [id]=@id" UpdateCommand="update [cards] set [shape]=@shape, [point]=@point where [id]=@id">
            <DeleteParameters>
                <asp:Parameter Name="id" />
            </DeleteParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="shape" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="shape" />
                <asp:Parameter Name="point" />
                <asp:Parameter Name="id" />
            </UpdateParameters>
        </asp:SqlDataSource>    
    </div>
    </form>
</body>
</html>
