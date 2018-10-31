<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyMultiView.aspx.cs" Inherits="MyMultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button3" runat="server" Text="Previous" OnClick="Button3_Click" /><asp:Button ID="Button4" runat="server" Text="Next" OnClick="Button4_Click" />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                 <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url" DisplayMode="HyperLink">
        </asp:BulletedList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/links.xml"></asp:XmlDataSource>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" DataSourceID="XmlDataSource1" DataTextField="text" DataValueField="url">
        </asp:CheckBoxList>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <table class="auto-style1" style="width:450px">
            <tr>
                <td style="text-align: right; width: 120px">姓名</td>
                <td class="auto-style2"><asp:TextBox ID="TextBox1" runat="server" Width="221px"></asp:TextBox></td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="請輸入姓名">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">年齡</td>
                <td class="auto-style2"><asp:TextBox ID="TextBox2" runat="server" Width="221px"></asp:TextBox></td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="請輸入年齡">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="年齡是介於0-120的整數" MaximumValue="120" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                    <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    

            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
