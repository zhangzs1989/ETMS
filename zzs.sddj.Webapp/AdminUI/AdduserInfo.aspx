<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdduserInfo.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.AdduserInfo" %>

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
            border:1px solid green;
        }
         .auto-style11 {
            width: 381px;
            border: 1px solid green;
            height: 36px;
        }
         table,tr
        {
            border:1px solid green;
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
            height: 44px;
        }
        .auto-style13 {
            width: 382px;
            height: 35px;
        }
        .auto-style14 {
            width: 181px;
            height: 46px;
        }
        .auto-style15 {
            width: 1086px;
            height: 46px;
        }
        .auto-style16 {
            width: 382px;
            height: 20px;
        }
        .style1
        {
            width: 181px;
            height: 42px;
        }
        .style2
        {
            width: 1086px;
            height: 42px;
        }
        .style3
        {
            width: 181px;
            height: 43px;
        }
        .style4
        {
            width: 1086px;
            height: 43px;
        }
        .style5
        {
            width: 181px;
            height: 44px;
        }
        .style6
        {
            width: 1086px;
            height: 44px;
        }
        .style7
        {
            width: 181px;
            height: 45px;
        }
        .style8
        {
            width: 1086px;
            height: 45px;
        }
        .style9
        {
            width: 181px;
            height: 49px;
        }
        .style10
        {
            width: 1086px;
            height: 49px;
        }
        .style11
        {
            width: 181px;
            height: 48px;
        }
        .style12
        {
            width: 1086px;
            height: 48px;
        }
        .style13
        {
            width: 181px;
            height: 50px;
        }
        .style14
        {
            width: 1086px;
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#"></a></li>
    <li><a href="#"></a></li>
    </ul>
    </div>
    <div>
    <table class="auto-style4">
        <tr><td class="auto-style2">姓名</td><td class="auto-style3"><input id="xingming" name="xingming" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="auto-style14">部门</td><td class="auto-style15">
            <select id="bumen" class="auto-style13" name="D1" runat="server" 
                style="border: medium solid #00FF00; background-color: #00FF00;">
                <option>山东省地震局</option>
                <option>办公室</option>
                <option>人事教育处</option>
                <option>发展与财务处</option>
                <option>科学技术处</option>
                <option>监测预报处</option>
                <option>震害防御处</option>
                <option>应急救援处</option>
                <option>纪检监察审计处</option>
                <option>机关党委</option>
                <option>离退休干部处</option>
                <option>财务室</option>
                <option>宣传教育中心</option>
                <option>地震预报研究中心</option>
                <option>地震台网中心</option>
                <option>地震监测中心</option>
                <option>工程地震研究中心</option>
                <option>地震应急保障中心</option>
                <option>基建办</option>
                <option>地震应急搜救中心</option><%将地震应急救援中心改为地震应急搜救中心-20190604 %>
                <option>泰安基准地震台</option>
                <option>聊城地震水化试验站</option>
                <option>青岛地震台</option>
                <option>烟台地震监测中心台</option>
                <option>长岛地震台</option>
                <option>莱阳地震台</option>
                <option>潍坊地震监测中心台</option>
                <option>昌邑地震台</option>
                <option>安丘地震台</option>
                <option>临沂地震监测中心台</option>
                <option>郯城马陵山地震台</option>
                <option>苍山地震台</option>
                <option>相公庄地震台</option>
                <option>沂水地震台</option>
                <option>菏泽地震监测中心台</option>
                <option>牛岚地震台</option>
                <option>嘉祥地震监测中心台</option>
                <option>邹城地震台</option>
                <option>德州地震台</option>
                <option>五莲地震台</option>
                <option>陵阳地震台</option>
                <option>大山地震台</option>                
                 <option>荣成地震台</option>
                
            </select></td></tr>
        <tr><td class="style3">性别</td><td class="style4"><select id="sex" 
                class="auto-style13"  name="D1" 
                runat="server" 
                style="border: medium solid #00FF00; background-color: #00FF00;">
                <option>男</option>
                <option>女</option>
            </select></td></tr>
        <tr><td class="style5">民族</td><td class="style6"><input id="minzu" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="style7">政治面貌</td><td class="style8"><input id="zzmm" type="text" runat="server" class="auto-style11" /></td></tr>
        <tr><td class="style9">类别</td><td class="style10"><select id="leibie"  
                class="auto-style13"  name="D1" runat="server" 
                style="background-color: #00FF00; border-style: solid; border-width: inherit; border-color: #00FF00">
                <option>处级及以上干部</option>
                <option>科级及以下干部</option>
                <option>专业技术人员</option>
                <option>工人</option>
            </select></td></tr>
        <%--<tr><td class="auto-style14">职务</td><td class="auto-style15"><select id="zhiwu" 
                class="auto-style12" name="D1" runat="server" 
                style="border: thick solid #00FF00; background-color: #00FF00;">
                <option>局长</option>
                <option>副局长</option>
                <option>主任</option>
                <option>副主任</option>
            </select></td></tr>--%>
        <%--<tr><td class="style11">行政级别</td><td class="style12"><select id="xzjb" 
                class="auto-style12" name="D1" runat="server" 
                style="border-style: solid; border-width: inherit; border-color: #00FF00; background-color: #00FF00;">
                <option>处级及以上干部</option>
                <option>科级及以下干部</option>
                <option>专业技术人员</option>
                <option>工人</option>
            </select></td></tr>
        <tr><td class="style1">专业技术</td><td class="style2"><select id="zhuangyejishu" 
                class="auto-style12" name="D1" runat="server" 
                style="border-style: solid; border-width: inherit; border-color: #00FF00; background-color: #00FF00">
                <option>高工</option>
                <option>工程师</option>
                <option>助理工程师</option>
                <option>见习期</option>
            </select></td></tr>--%>
        <%--<tr><td class="style13">文化水平</td><td class="style14"><select id="whsp" 
                class="auto-style12" name="D1" runat="server" 
                style="background-color: #00FF00; border-style: solid; border-width: inherit; border-color: #00FF00">
                <option>研究生</option>
                <option>博士</option>
                <option>本科</option>
                <option>大专</option>
                <option>高中</option>
            </select></td></tr>
        <tr><td class="style9">身份证号</td><td class="style10"><input id="sfzh" type="text" runat="server" class="auto-style11" /></td></tr>--%>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="提交信息" Height="42px" Width="91px" OnClick="Button1_Click" /></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
