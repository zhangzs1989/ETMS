<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="restoresql.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.restoresql" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server">
<div>
<table>
<tr>
<td style="width: 100px">
<span style="font-size: 9pt">操 作 数 据 库</span>
</td>
<td>
<asp:DropDownList ID="DropDownList1" runat="server" Font-Size="9pt" Width="124px">
</asp:DropDownList>
<asp:TextBox ID="txtDbName" runat="server"></asp:TextBox>
</td>
<td style="width: 100px">
</td>
</tr>
<tr>
<td style="width: 100px">
<span style="font-size: 9pt">备份名称和位置</span>
</td>
<td style="width: 100px">
<asp:TextBox ID="TextBox1" runat="server" Font-Size="9pt" Width="117px"></asp:TextBox>
</td>
<td style="width: 100px">
<span style="font-size: 9pt; color: #ff3300">（如D:\beifen）</span>
</td>
</tr>
<tr>
<td colspan="3">
<asp:Button ID="Button1" runat="server" Font-Size="9pt" OnClick="Button1_Click" Text="备份数据库" />
</td>
</tr>
</table>
</div>
<div style="width: 100%; height: 100px">
<table>
<tr>
<td style="width: 100px; height: 21px">
<span style="font-size: 9pt">操 作 数 据 库</span>
</td>
<td>
<asp:DropDownList ID="DropDownList2" runat="server" Font-Size="9pt" Width="124px">
</asp:DropDownList>
</td>
<td style="width: 100px; height: 21px">
</td>
</tr>
<tr>
<td style="width: 100px">
<span style="font-size: 9pt">操 作 数 据 库</span>
</td>
<td style="width: 100px">
<asp:FileUpload ID="FileUpload1" runat="server" Font-Size="9pt" Width="190px" />
</td>
<td style="width: 100px">
</td>
</tr>
<tr>
<td colspan="3">
<asp:Button ID="Button2" runat="server" Font-Size="9pt" OnClick="Button2_Click" Text="还原数据库" />
<asp:Button ID="Button3" runat="server" Font-Size="9pt" OnClick="Button3_Click" Text="强制还原数据库" />
</td>
</tr>
</table>
</div>
</form>
</body>
</html> 