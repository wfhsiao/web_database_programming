<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
        .auto-style2 {
            width: 15%;
            height: 23px;
        }
        .auto-style3 {
            width: 45%;
            height: 23px;
        }
        .auto-style4 {
            width: 40%;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td style="text-align: right; " class="auto-style2"><span style="color: rgb(102, 51, 0); font-family: verdana, arial, helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 700; letter-spacing: normal; orphans: 2; text-align: right; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">姓名</span></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="請輸入姓名" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right"><span style="color: rgb(102, 51, 0); font-family: verdana, arial, helvetica, sans-serif; font-size: small; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 700; letter-spacing: normal; orphans: 2; text-align: right; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">年齡</span></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="請輸入年齡" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="年齡介於0-120歲" ForeColor="Red" MaximumValue="120" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
             <tr>
                <td style="text-align: right">身份證號</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="98%"></asp:TextBox>
                </td>
                 <td>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="請輸入正確的身份證號" ForeColor="Red" ValidationExpression="[a-zA-Z]{1}[12]{1}[0-9]{8}"></asp:RegularExpressionValidator>
                 </td>
            </tr>
            <tr>
                <td style="text-align: right">email</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="請輸入正確的email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">IsEven?</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="98%"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="請輸入偶數" ForeColor="Red" OnServerValidate="IsEven"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                    <br />
                </td>
            </tr>
           
        </table>
    
    </div>
    </form>
</body>
</html>
