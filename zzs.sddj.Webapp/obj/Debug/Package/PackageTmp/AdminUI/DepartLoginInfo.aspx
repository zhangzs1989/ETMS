﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartLoginInfo.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.DepartLoginInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>部门登录信息</title>
    <link href="css2/style.css" rel="stylesheet" type="text/css" />
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
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form action="DepartLoginInfo.aspx" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">信息维护</a></li>
    <li><a href="#">部门登录信息</a></li>
    </ul>
    </div>
    添加用户：<asp:Button ID="adduser" runat="server" Height="30px" OnClick="addbumen_Click" Text="点击添加" Width="66px" />
&nbsp;
    <div class="rightinfo">
    <table class="tablelist">
    	<tr>
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">用户名</th>
        <th style="text-align:center">密码</th>
        <th style="text-align:center">操作</th>
        </tr>
        <%=StrHtml %>
    </table>
    
   <div class="pages">
           
                   <a href="DepartLoginInfo.aspx?pageindex=1"> 首页</a>  | <a href="DepartLoginInfo.aspx?pageindex=<%=Pageindex-1 %>"> 前页 </a>  | 
                    

                      <a href="DepartLoginInfo.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="DepartLoginInfo.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>  |  页次 <%=Pageindex %>/<%=Pagecounts %>页  
                    <hr />
                   
    </div>
    <div class="tip">
    	<div class="tiptop"><span>提示信息</span><a></a></div>
        
      <div class="tipinfo">
        <span><img src="images/ticon.png" /></span>
        <div class="tipright">
        <p>是否确认对信息的修改 ？</p>
        <cite>如果是请点击确定按钮 ，否则请点取消。</cite>
        </div>
        </div>
        
        <div class="tipbtn">
        <input name="" type="button"  class="sure" value="确定" />&nbsp;
        <input name="" type="button"  class="cancel" value="取消" />
        </div>
    
    </div>
    
    
    
    
    </div>
    
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    
    </form>
	
</body>
</html>
