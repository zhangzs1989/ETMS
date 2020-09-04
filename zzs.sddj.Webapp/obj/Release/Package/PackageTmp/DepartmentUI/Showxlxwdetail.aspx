<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Showxlxwdetail.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.Showxlxwdetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../UserUI/css/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style4 {
            width: 680px;
            height: 381px;
        }
        table,tr
        {
            border:1px none green;
            align-content:center;
            vertical-align:middle;
            text-align:center;
            
            
        }
        table
        {
            border-collapse:collapse;
            align-content:center;
           
        }

        .listboxcss{
            border:1px solid green;
            border-right-color:aqua;
            color:red;
            width:250px;
            border-left:-50px;

        }

        /*.auto-style9 {
            border-right: 1px solid aqua;
            color: red;
            width: 250px;
            left: 7px;
            top: -2px;
            height: 265px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: -50px;
            border-top-style: solid;
            border-top-color: inherit;
            border-top-width: 1px;
            border-bottom-style: solid;
            border-bottom-color: inherit;
            border-bottom-width: 1px;
        }*/

        .auto-style11 {
            width: 381px;
            border: 1px solid green;
            height: 36px;
        }
        .auto-style12 {
            width: 381px;
            border: 1px solid green;
            height: 35px;
        }

        .auto-style13 {
            height: 39px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">学历学位升级教育</a></li>
    <li><a href="#">查看详情</a></li>
    </ul>
    </div>
    <div>
     <table class="auto-style4">
            
            <tr><td>升 级 类 型:</td><td colspan="2"><input type="text" id="leixing" name="leixing"  runat="server"  class="auto-style11" disabled="true"/></td></tr>
            <tr><td>就 读 学 校   :</td><td colspan="2"><input type="text" id="scool" name="scool" runat="server" class="auto-style11" disabled="true"/></td></tr>
            <tr><td>就 读 专 业   :</td><td colspan="2"><input type="text" id="major" name="major"  runat="server" class="auto-style12" disabled="true"/></td></tr>
            <tr><td>就 读 地 点   :</td><td colspan="2"><input type="text" id="didian" name="didian"  runat="server" class="auto-style12" disabled="true"/></td></tr>
            <tr><td>开 始 时 间   :</td><td colspan="2"><input type="text" id="kaishitime" name="kaishitime"  runat="server" class="auto-style11" disabled="true"/></td></tr>
            <tr><td>结 束 时 间   :</td><td colspan="2"><input type="text" id="jieshutime" name="jieshutime"  runat="server" class="auto-style11" disabled="true"/></td></tr>
            
            <tr><td>审 批</td><td colspan="2" class="auto-style13">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="81px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>所在部门通过审批</asp:ListItem>
                    <asp:ListItem>所在部门不通过审批</asp:ListItem>
                </asp:DropDownList></td></tr>
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="确定并返回" Height="41px" Width="91px" OnClick="Button1_Click" BackColor="#999999" /></td></tr>
                
        </table>
    </div>
    </form>
</body>
</html>
