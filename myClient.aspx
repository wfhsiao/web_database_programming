<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myClient.aspx.cs" Inherits="myClient_callSelf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" action="myClient.aspx" method="post" runat="server">
    <div>
    <input type="text" name="point" />
    <input type="text" name="shape" />       
    <input id="Submit1" type="submit" value="submit" /><br />
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
