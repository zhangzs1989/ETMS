<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upzhidu.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Upzhidu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>制度规定</title>
   <meta charset="utf-8">
    <link rel="stylesheet" media="screen" href="styles.css"/>
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="Form1" class="contact_form" action="Upzhidu.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
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
        <label for="message">有关制度文件上传:</label>
        <input id="homeworkFile" type="file" runat="server" />  
        
        <%--<asp:FileUpload ID="homeworkFile" runat="server" />--%>
        <%--<asp:Button ID="BtnUp" runat="server" onclick="BtnUp_Click" Text="上 传" />--%>
        <%--<asp:Label ID="LabMsg" runat="server"></asp:Label>--%>
    </li>    
        <li>
            <asp:Button ID="btnupfile_Click" runat="server" Text="提交信息" Width="150px" Font-Size="Medium" Height="30px" OnClick="btnupfile_Click_Click" />
        </li>
	<%--<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%--<asp:Button ID="Button1" class="submit" type="submit" OnClick="btnupfile_Click" Text="提交信息" 
            runat="server" Width="150px" Font-Size="Medium" Height="30px" />
        
	</li>--%>
	</ul>
	</form>
</body>
</html>