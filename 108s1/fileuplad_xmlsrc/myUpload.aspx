<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myUpload.aspx.cs" Inherits="myUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" Width="501px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="upload" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Visible="False">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
