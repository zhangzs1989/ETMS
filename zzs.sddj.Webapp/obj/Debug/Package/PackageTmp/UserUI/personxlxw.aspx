﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personxlxw.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.personxlxw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>学历学位升级查询</title>
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
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">培训情况查询</a></li>
    <li><a href="#">学历学位升级</a></li>
    </ul>
    <div class="rightinfo">
    <table class="tablelist">
    	
    	<tr>
        <!--<th><input name="" type="checkbox" value="" checked="checked"/></th>-->
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">姓名</th>
        <th style="text-align:center">升级类型</th>
        <th style="text-align:center">开始时间</th>
        <th style="text-align:center">结束时间</th>
        <th style="text-align:center">就读学校</th>
        <th style="text-align:center">就读专业</th>
        <%--<th style="text-align:center">审批状态</th>--%>
        <%--<th style="text-align:center">操作</th>--%>
        </tr>
        <%=StrHtml%>
        
    </table>
    <h5 style="font-size:small">提示:学历学位教育不计入脱产培训学时。</h5>
   <div class="pages">
           
                   <a href="personxlxw.aspx?pageindex=1"> 首页</a>  | <a href="personxlxw.aspx?pageindex=<%=Pageindex-1 %>"> 前页</a>  | 
                    

                      <a href="personxlxw.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="personxlxw.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>   | 页次 <%=Pageindex %>/<%=Pagecounts %>页 
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
