<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Button.aspx.cs" Inherits="Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" ID="btnAddMenu" OnClick="btnAddMenu_Click" Text="创建菜单"/>
    </div>
    </form>
</body>
</html>
