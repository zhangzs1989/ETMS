<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juneitrainperson.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Juneitrainperson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>局内培训管理</title>
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
    <li><a href="#">局内培训管理</a></li>
    <li><a href="#">局内个人参训管理</a></li>
    </ul>
    </div>
    <%--添加用户：<asp:Button ID="adduser" runat="server" Height="30px" OnClick="adduser_Click" Text="点击添加" Width="66px" />
&nbsp;<br />--%>
    查询姓名：<input id="jnchaxun" type="text" runat="server" class="auto-style1" style="background-color: #FFFF00; list-style-type: circle" /><asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="点击查询" Width="66px" />
&nbsp;
    <div>
    <table class="tablelist">
    	
    	<tr>
        <!--<th><input name="" type="checkbox" value="" checked="checked"/></th>-->
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">年度</th>
        <th style="text-align:center">姓名</th>
        <th style="text-align:center">培训班名称</th>
        <th style="text-align:center">培训时间</th>
        <%--<th style="text-align:center">民族</th>--%>
        <th style="text-align:center">培训学时</th>
        <%--<th style="text-align:center">类别</th>--%>
        <%--<th style="text-align:center">职务</th>
        <th style="text-align:center">行政级别</th>
        <th style="text-align:center">专业技术</th>
        <th style="text-align:center">文化水平</th>
        <th style="text-align:center">身份证号</th>--%>
        <th style="text-align:center">操作</th>
        </tr>
        <%=StrHtml%>
        
    </table>
    </div>

        <div class="pages">
           
                   <a href="Juneitrainperson.aspx?pageindex=1"> 首页</a>  |  <a href="Juneitrainperson.aspx?pageindex=<%=Pageindex-1 %>"> 前页 </a>  | 
                      <a href="Juneitrainperson.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="Juneitrainperson.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>   | 页次 <%=Pageindex %>/<%=Pagecounts %>页 
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
    
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>

    </div>
    </form>
</body>
</html>

