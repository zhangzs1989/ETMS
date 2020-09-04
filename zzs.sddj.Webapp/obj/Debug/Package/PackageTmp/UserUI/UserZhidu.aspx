<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserZhidu.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.UserZhidu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link href="WebDemos/style/style.css" type="text/css" rel="stylesheet" />
<link rel="icon" href="WebDemos/favicon.ico" type="image/x-icon" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body class="body_column">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">通知公告</a></li>
    <li><a href="#">制度规定</a></li>
    </ul>
    </div>
            <div class="cont">
            	<ul class="list_news">
            	  <% =strhtml %>
            	</ul>
                <div class="pages">首页  |  前页  |  后页 | 尾页         页次：1/3页 </div>
            </div>
        
      	<div class="clear"></div>
     
       <!----------------------------------end main_column---------------------------------->
      <!----------------------------------begin footer_column----------------------------------><!-- #BeginLibraryItem "/Library/fooer.lbi" -->
        <!-- #EndLibraryItem --><!----------------------------------end footer_column---------------------------------->
	</div>
</body>
</html>
