<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLoginInfo.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.UserLoginInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>网站后台管理系统</title>
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
    <form action="UserLoginInfo.aspx" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">通知公告</a></li>
    <li><a href="#">最新通知</a></li>
    </ul>
    </div>
    添加用户：<asp:Button ID="adduser" runat="server" Height="30px" OnClick="adduser_Click" Text="点击添加" Width="66px" />
&nbsp;<br />
    查询姓名：<input id="chaxunname" type="text" runat="server" class="auto-style1" style="background-color: #FFFF00; list-style-type: circle" /><asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="点击查询" Width="66px" />
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
           
                   <a href="UserLoginInfo.aspx?pageindex=1"> 首页</a>  | <a href="UserLoginInfo.aspx?pageindex=<%=Pageindex-1 %>>">前页</a>  | 
                    

                      <a href="UserLoginInfo.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="UserLoginInfo.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>  |  页次 <%=Pageindex %>/<%=Pagecounts %>页  
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