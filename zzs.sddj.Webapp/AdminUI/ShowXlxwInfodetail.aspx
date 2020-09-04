<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowXlxwInfodetail.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.ShowXlxwInfodetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>用户信息管理</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $(".click").click(function () {
            $(".tip").fadeIn(200);
        });

        $(".tiptop a").click(function () {
            $(".tip").fadeOut(200);
        });

        $(".sure").click(function () {
            $(".tip").fadeOut(100);
        });

        $(".cancel").click(function () {
            $(".tip").fadeOut(100);
        });

    });
</script>
    <style type="text/css">
        .auto-style2 {
            width: 181px;
        }
        .auto-style3 {
            width: 1086px;
        }
        .auto-style4 {
            width: 680px;
        }
         .auto-style11 {
            width: 381px;
            border: 1px solid green;
            height: 36px;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">培训情况综合管理</a></li>
    <li><a href="#">局内培训查询</a></li>
    </ul>
    </div>
    <div>
    <table class="auto-style4">
        <tr><td class="auto-style2">申请人</td><td class="auto-style3"><input id="xingming" name="xingming" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">升级类型</td><td class="auto-style3"><input id="bumen" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">就读学校</td><td class="auto-style3"><input id="sex" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">就读专业</td><td class="auto-style3"><input id="minzu" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">地点</td><td class="auto-style3"><input id="didian" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">开始时间</td><td class="auto-style3"><input id="zzmm" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">结束时间</td><td class="auto-style3"><input id="leibie" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">审批状态</td><td class="auto-style3"><input id="zhiwu" type="text" runat="server" disabled="true" class="auto-style11" /></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button2" runat="server" Text="返回列表" Height="42px" Width="91px" OnClick="Button1_Click" /></td></tr>
        
    </table>
    </div>
    </form>
</body>
</html>
