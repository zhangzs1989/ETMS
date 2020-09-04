<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Etmsplan.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.Etmsplan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>年度教育培训计划</title>
    <link rel="stylesheet" media="screen" href="styles.css"/>
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<form id="Form1" class="contact_form" action="Etmsplan.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>提交年度教育培训计划</h2>
         <%--<span class="required_notification">* 表示必填项</span>--%>
    </li>
	<li>
    <label for="email">年度:</label>
    <input type="text" name="niandu" maxlength="4" onkeyup="this.value=this.value.replace(/\D/g,'')" required/>
    <span class="form_hint"></span>
	</li>
    <li>
        <label for="message">上传培训计划表:</label>
    <!--<input type="file" name="shangchuanwenjian" style="border:1px solid gray;color:red;font:bold 12px '隶书';height:30px;width:300px"/>-->
        <asp:FileUpload ID="homeworkFile" runat="server" Height="33px" />
        <!--<asp:Button ID="btndownfilebystream" runat="server" Text="上传" 
            OnClick="btnupfile_Click" Width="79px" />-->
    </li>            
	<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" class="submit" type="submit" OnClick="btnupfile_Click" Text="提交" 
            runat="server" Width="150px" Font-Size="Medium" Height="30px" />
	</li>
	</ul>
	</form>
</body>
</html>
