﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDepartLoginInfo.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.AddDepartLoginInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>添加部门登录信息</title>
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
    <li><a href="#">部门信息</a></li>
    <li><a href="#">添加部门登录账号</a></li>
    </ul>
    </div>
    <div>
    <table class="auto-style4">
        <tr><td class="auto-style2">部门</td><td class="auto-style3"><input id="xingming" name="xingming" type="text" runat="server"  class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">密码</td><td class="auto-style3"><input id="mima" type="text" runat="server"  class="auto-style11" /></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="添加新用户" Height="42px" Width="91px" OnClick="adduserlogin_Click" /></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
