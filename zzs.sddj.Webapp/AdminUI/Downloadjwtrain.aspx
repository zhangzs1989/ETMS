<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Downloadjwtrain.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Downloadjwtrain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    输入局外培训表格年限：<input id="niandu" type="text" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="点击导出" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
