<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JwManager.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.JwManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>本部门组织培训情况</title>
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
        .auto-style4 {
            width: 143px;
            height: 26px;
        }
    </style>
</head>


<body>
    <form runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">局外培训管理</a></li>
    <li><a href="#">局外组织培训情况</a></li>
    </ul>
    </div>
        <%--<table>
            <tr><td>输入查询姓名：</td><td> <input id="name" type="text" runat="server" class="auto-style4" style="border-style: solid; background-color: #FFFF00" />
        <asp:Button ID="Button1" runat="server" Text="点击查询" Height="26px" OnClick="Button1_Click" Width="92px" BackColor="Lime" /></td></tr>--%>
           <%-- <tr><td>添加新的培训：</td><td>
                <asp:Button ID="Button2" runat="server" Text="点击添加" Height="27px" Width="154px" BackColor="Lime" OnClick="Button2_Click" /></td></tr>
        </table>--%>
    <div class="rightinfo">        
        <table class="tablelist">
         <tr>  
        <!--<th><input name="" type="checkbox" value="" checked="checked"/></th>-->
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">培训年度</th>
        <th style="text-align:center">培训班名称</th>
        <th style="text-align:center">培训人</th>
        <%--<th style="text-align:center">培训地点</th>--%>
        <th style="text-align:center">培训时间</th>
        <th style="text-align:center">培训学时</th>
        <%--<th style="text-align:center">培训主办</th>--%>
        <%--<th style="text-align:center">审批状态</th>--%>
        <th style="text-align:center">操作</th>
        </tr>
        <%=StrHtml%>
        
    </table>
    
   <div class="pages">
           
                   <a href="JwManager.aspx?pageindex=1"> 首页</a>  | <a href="JwManager.aspx?pageindex=<%=Pageindex-1 %>"> 前页 </a>  | 
                    

                      <a href="JwManager.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="JwManager.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>   | 页次 <%=Pageindex %>/<%=Pagecounts %>页
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