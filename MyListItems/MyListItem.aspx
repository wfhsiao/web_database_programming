﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyListItem.aspx.cs" Inherits="MyListItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="body1" runat="server">
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>