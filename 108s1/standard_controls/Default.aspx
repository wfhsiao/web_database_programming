<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" AccessKey="a"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" AccessKey="b"></asp:TextBox>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <asp:Button ID="Button1" runat="server" AccessKey="c" BorderColor="#FFCC00" BorderStyle="Dashed" BorderWidth="4px" OnClick="Button1_Click" Text="Button" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://tw.dictionary.search.yahoo.com/">yahoo字典</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="https://translate.google.com/">google翻譯</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Default2.aspx">Default2</asp:HyperLink>
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" Value="Author Jean" />
        <br />
        <asp:Image ID="Image1" runat="server" AlternateText="Andy Lau" Height="250px" ImageUrl="https://image.cache.storm.mg/styles/smg-800x533-fp/s3/media/image/2018/10/08/20181008-034735_U13451_M460725_203e.png?itok=ghV8jlkK" />
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="OK" />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" RepeatColumns="2" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        <br />
    
    </div>
    </form>
</body>
</html>
