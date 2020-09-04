<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanupwlxxjisuan.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Usercanupwlxxjisuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        选择网络学时文件：<br />
        <asp:ListBox ID="ListBox1" runat="server" Height="143px"></asp:ListBox><br />
         <asp:Button ID="Button1" runat="server" Text="添加到本年度网络学时档案中" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
