<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Userzhidulist.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Userzhidulist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>制度文件</title>
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
    <form id="Form1" method="post" runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="Userindex.ashx">通知公告</a></li>
    <li><a href="Userzhidulist.aspx">制度文件</a></li>
    </ul>
    </div>
    
    <div class="rightinfo"> 
    <table class="tablelist">	
    	<tr>    
        <th style="text-align:center">编号<i class="sort"></i></th>
        <th style="text-align:center">标题</th>
        <th style="text-align:center">上传时间</th>
        <th style="text-align:center">上传人</th>
        <th style="text-align:center">操作</th>
        </tr>
        
        <%=StrHtml %>
    </table>
    
   
    <div class="pages">
           
                   <a href="Userzhidulist.aspx?pageindex=1"> 首页</a>  | <a href="Userzhidulist.aspx?pageindex=<%=Pageindex<=1?1:Pageindex-1 %>>">前页</a>  | 
                    

                      <a href="Userzhidulist.aspx?pageindex=<%=Pageindex>=Pagecounts?Pagecounts:Pageindex+1 %>">后页</a> |  <a href="Userzhidulist.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>   | 页次 <%=Pageindex %>/<%=Pagecounts %>页 
                    <hr />
                   
     </div>
    
    
   <%-- <div class="tip">
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
    
    </div>--%>
    </div>
    
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    
    </form>
	
</body>
</html>