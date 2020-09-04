<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="true" CodeBehind="Juneitrainrenyuan.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.Juneitrainrenyuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 39px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr><td class="auto-style1"><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mydbConnectionString2 %>" SelectCommand="SELECT [ID], [Danwei] FROM [DanweiInfo]"></asp:SqlDataSource>
                </td></tr>
            
            <tr><td colspan="3" class="auto-style2"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" AutoPostBack="True"  ></asp:DropDownList>
                </td></tr>
            <tr><td rowspan="4"><asp:ListBox ID="leftlistbox" runat="server" CssClass="auto-style10" SelectionMode="Multiple" Height="214px" Width="129px"  OnTextChanged="add_Click"></asp:ListBox></td></tr>
            <tr><td> </td><td rowspan="3"><asp:ListBox ID="rightlistbox" runat="server"  CssClass="auto-style9" SelectionMode="Multiple" Height="213px" Width="126px"></asp:ListBox></td></tr>
          
            <tr><td class="auto-style3">
                <asp:Button ID="add" runat="server" Text="添加" OnClick="add_Click" />
                </td></tr>
            
            <tr><td class="auto-style3">
                <asp:Button ID="remove" runat="server" Height="36px" Text="删除 <=" Width="118px"  />
                </td></tr>
            <tr><td colspan="3" class="auto-style2"></td></tr>
            <tr><td class="auto-style3" colspan="3">
                <asp:Button ID="Button3" runat="server" Height="35px" Text="提 交" Width="124px"  />
                </td></tr>
    </table>
    </form>
</body>
</html>
