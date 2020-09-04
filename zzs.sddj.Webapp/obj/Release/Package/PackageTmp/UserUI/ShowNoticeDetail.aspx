<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowNoticeDetail.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.ShowNoticeDetail" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<script src="../AdminUI/utf8_net/ueditor.config.js" type="text/javascript"></script>--%>
    <script src="../AdminUI/utf8_net/ueditor.config.js" type="text/javascript"></script>
    <script src="../AdminUI/utf8_net/ueditor.all.min.js" type="text/javascript"></script>
    <script src="../AdminUI/utf8_net/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <link href="../AdminUI/utf8_net/themes/default/css/ueditor.css" rel="stylesheet" type="text/css" />
   <%-- <script src="../AdminUI/utf8_net/ueditor.all.min.js" type="text/javascript"></script>
    <script src="../AdminUI/utf8_net/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <link href="../AdminUI/utf8_net/themes/default/css/ueditor.css" rel="stylesheet"
        type="text/css" />--%>
</head>
<body>
    <form id="form1" runat="server" action="ShowNoticeDetail.aspx">
     <FTB:FreeTextBox ID="FreeTextBox2" runat="server" Height="1000px" Width="3000px"></FTB:FreeTextBox>
     <%-- <textarea id="myEditor" name="myEditor" style="height:400px" runat="server">--%>
      <%--<textarea id="myEditor" name="myEditor" style="height:400px" runat="server" onblur="setUeditor()"></textarea>
      </textarea>
      <script type="text/javascript">
          var editor = new baidu.editor.ui.Editor();
          editor.render("myEditor");
          editor.getAllHtml();
      </script>--%>
      <%--<script type="text/plain" id="myEditor">初始内容</script>--%>
      
         <%--<div id="myEditor">
          <script id="editor" type="text/plain" style="width: 100%; height: 300px;"></script>
        </div>
--%>

    </form>
    <%--<script type="text/javascript">
        function setUeditor() 
        {
            var myEditor = document.getElementById("myEditor");
            myEditor.value = editor.getContent;  
        }
    </script>--%>
    
</body>
</html>
