﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanxunjj.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Usercanxun" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>网站后台管理系统</title>
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
</head>


<body>
    <form runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">通知公告</a></li>
    <li><a href="#">最新通知</a></li>
    </ul>
    </div>
    
    <div class="rightinfo">
    
    <table class="tablelist">
    	
    	<tr>
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">培训名称</th>
        <th style="text-align:center">培训方式</th>
        <th style="text-align:center">培训学时</th>
        <th style="text-align:center">培训时间</th>
        <th style="text-align:center">审批状态</th>
        <th style="text-align:center">操作</th>
        </tr>
        <%=StrHtml%>
    </table>
    <br />
    <h1>您共参与局外培训<%=juwaicounts %>次，共修<%=juwaixuefen %>学分，您今年还需要修<%=juwaibugou %>学分</h1>
      
   <div class="pages">
           
                   <a href="Usercanxun.aspx?pageindex=1"> 首页</a>  | <a href="Usercanxun.aspx?pageindex=<%=Pageindex-1 %>>">前页</a>  | 
                    

                      <a href="Usercanxun.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="Usercanxun.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>        页次：1/3页 
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

