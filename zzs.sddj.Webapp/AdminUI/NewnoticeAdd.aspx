<%@ Page Language="C#" validateRequest="false" AutoEventWireup="true" CodeBehind="NewnoticeAdd.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.NewnoticeAdd" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <script src="utf8_net/ueditor.config.js" type="text/javascript"></script>
    <script src="utf8_net/ueditor.all.min.js" type="text/javascript"></script>
    <script src="utf8_net/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <link href="utf8_net/themes/default/css/ueditor.css" rel="stylesheet" type="text/css" />
    
   
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode", sans-serif;>
	<form id="Form1" class="contact_form" action="NewnoticeAdd.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>发布通知公告</h2>
         <span class="required_notification">* 表示必填项</span>
         
    </li>
    <li>
        <label for="name">标题:</label>
        <input type="text" name="noticetitle" required/>
    </li>
    <%--<li>
        <label for="name">副标题:</label>
        <input type="text" name="noticefutitle" required/>
    </li>--%>
    <li>
        <label for="name">发布人:</label>
        <input type="text" name="faburen" required/>
    </li>
    <li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        <asp:Button ID="Button1" class="submit"  type="submit" OnClick="btnupfile_Click" Text="发布通知" 
            runat="server" Width="80px" Height="50px"  BackColor="#BCEE68" ForeColor="Black" Font-Size="Medium"/>
	 </li>
      <FTB:FreeTextBox ID="FreeTextBox1" runat="server" Height="500px" Width="1000px" ></FTB:FreeTextBox>
    <%--<script type="text/plain" id="myEditor" style="height:500px" ></script>--%>
    <%--<textbox name="content" id="content"><%Req%></textbox>--%>
    <%--<asp:HiddenField ID="HiddenField1" runat="server" />--%>
   <%--<textarea id="myEditor" name="myEditor" style="height:400px" runat="server" onblur="setUeditor()"></textarea>--%>
    
	</ul>
	</form>
    
    
     <%--<script type="text/javascript">
        var editor = new baidu.editor.ui.Editor();
        editor.render("myEditor");
      </script> --%>
     
</body>
</html>
