<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="mybody" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
            <br />
            <br />
            從<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            一直加到<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            等於<asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="計算" />
        </div>
    </form>
</body>
</html>
