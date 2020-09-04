﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdduserInfo.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.AdduserInfo" %>

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
        .auto-style12 {
            width: 382px;
            height: 25px;
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
        <tr><td class="auto-style2">姓名</td><td class="auto-style3"><input id="xingming" name="xingming" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">部门</td><td class="auto-style3">
            <select id="bumen" class="auto-style12" name="D1" runat="server">
                <option>办公室</option>
                <option>人事处</option>
            </select></td></tr>
        <tr><td class="auto-style2">性别</td><td class="auto-style3"><select id="sex" class="auto-style12" name="D1" runat="server">
                <option>男</option>
                <option>女</option>
            </select></td></tr>
        <tr><td class="auto-style2">民族</td><td class="auto-style3"><input id="minzu" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">政治面貌</td><td class="auto-style3"><input id="zzmm" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="auto-style2">类别</td><td class="auto-style3"><select id="leibie" class="auto-style12" name="D1" runat="server">
                <option>处级及以上干部</option>
                <option>科级及以上干部</option>
                <option>事业单位</option>
                <option>工人</option>
            </select></td></tr>
        <tr><td class="auto-style2">职务</td><td class="auto-style3"><select id="zhiwu" class="auto-style12" name="D1" runat="server">
                <option>局长</option>
            </select></td></tr>
        <tr><td class="auto-style2">行政级别</td><td class="auto-style3"><select id="xzjb" class="auto-style12" name="D1" runat="server">
                <option>局长</option>
                <option>副局长</option>
                <option>主人</option>
            </select></td></tr>
        <tr><td class="auto-style2">专业技术</td><td class="auto-style3"><select id="zhuangyejishu" class="auto-style12" name="D1" runat="server">
                <option>高工</option>
                <option>工程师</option>
                <option>助理工程师</option>
                <option>见习期</option>
            </select></td></tr>
        <tr><td class="auto-style2">文化水平</td><td class="auto-style3"><select id="whsp" class="auto-style12" name="D1" runat="server">
                <option>研究生</option>
                <option>博士</option>
                <option>本科</option>
                <option>大专</option>
                <option>高中</option>
            </select></td></tr>
        <tr><td class="auto-style2">身份证号</td><td class="auto-style3"><input id="sfzh" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="添加" Height="42px" Width="91px" OnClick="Button1_Click" /></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
