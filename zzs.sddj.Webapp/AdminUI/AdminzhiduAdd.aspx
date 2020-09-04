<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminzhiduAdd.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.AdminzhiduAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>制度规定</title>
   <meta charset="utf-8">
    <link rel="stylesheet" media="screen" href="styles.css"/>
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="Form1" class="contact_form" action="AdminzhiduAdd.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>发布制度规定文件</h2>
         <%--<span class="required_notification">* 表示必填项</span>--%>
    </li>
    <li>
        <label for="name">标题:</label>
        <input type="text" name="zhiduname" required/>
    </li>
	<li>
    <label for="email">发布人:</label>
    <input type="text" name="shangchuanzhe" required/>
    <span class="form_hint"></span>
	</li>
    <li>
        <label for="message">相关材料打包上传:</label>
    <!--<input type="file" name="shangchuanwenjian" style="border:1px solid gray;color:red;font:bold 12px '隶书';height:30px;width:300px"/>-->
        <asp:FileUpload ID="homeworkFile" runat="server" Height="33px" />
        <!--<asp:Button ID="btndownfilebystream" runat="server" Text="上传" 
            OnClick="btnupfile_Click" Width="79px" />-->
    </li>    
        
	<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" class="submit" type="submit" OnClick="btnupfile_Click" Text="提交信息" 
            runat="server" Width="150px" Font-Size="Medium" Height="30px" />
	</li>
	</ul>
	</form>
</body>
</html>
