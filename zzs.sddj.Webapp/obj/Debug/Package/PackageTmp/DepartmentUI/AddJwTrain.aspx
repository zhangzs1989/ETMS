<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJwTrain.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.AddJwTrain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <title>HTML5 Contact Form</title>
    <link rel="stylesheet" media="screen" href="styles.css" rel="external nofollow" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 394px;
            height: 211px;
        }
    </style>
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode", sans-serif;>
	<form class="contact_form" action="AddJwTrain.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>局外参训登记</h2>
         <%--<span class="required_notification">* 表示必填项</span>--%>
    </li>
        <li>
        <label for="name">培训人姓名:</label>
        <input type="text" name="peixunren" required="必填项"/>
    </li>

    <li>
        <label for="name">培训班名称:</label>
        <input type="text" name="peixunname" id="peixunname" runat="server" required/>
    </li>
	<li>
        <label for="name">培训方式:</label>
        <!--<input type="text" name="name" required/>-->
        <select  class="peixunfangshi" name="peixunfangshi" id="peixunfangshi" style="font-size:13px" runat="server">
        <option class="fangshifontcolor">中国地震局组织的培训 </option>
        <option class="fangshifontcolor">省委或省政府组织的培训</option>
        <option class="fangshifontcolor">中央组织的培训</option>
        <option class="fangshifontcolor">省局外的其他培训</option>
         
        </select>
    </li>
	<li>
    <label for="email">培训主办机构:</label>
    <input type="text" name="peixunzhuban" id="peixunzhuban" runat="server" required/>
    <span class="form_hint"></span>
	</li>
	<li>
    <label for="email">培训承办机构:</label>
    <input type="text" name="peixunchengban" runat="server" id="peixunchengban" required/>
    <span class="form_hint"></span>
	</li>
    <li>
    <label for="email">培训年度:</label>
    <input type="text" name="peixunniandu" runat="server" id="peixunniandu" maxlength="4" onkeyup="this.value=this.value.replace(/\D/g,'')" onfocus="javascript:if(this.value=='请输入内容')this.value='';" required/>
    <span class="form_hint"></span>
	</li>
	<li>
    <label for="website">培训起止时间:</label>
    <input type="text" name="peixunshijian" id="peixunshijian" runat="server" required/>
    <%--<span class="form_hint">格式：20160101-20170101</span>--%>
	</li>
	<li>
        <label for="name">培训学时:</label>
        <input type="text" name="peixunxueshi" id="peixunxueshi" runat="server" onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" required/>
        <span class="form_hint">例：32</span>
        <%--<span style="color:red"><%=xueshimsg %></span>--%>
    </li>
    <li>
        <label for="name">培训地点:</label>
        <input type="text" name="peixundidian" id="peixundidian" runat="server" required/>
    </li>
	<li>
    <label for="message">培训主要内容:</label>
    <textarea name="peixunneirong" id="peixunneirong" runat="server"  placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style1" required></textarea>
	</li>
    <%--<li>
        <label for="message">相关材料打包上传:</label>
    
        <asp:FileUpload ID="homeworkFile" runat="server" />
        <span class="form_hint">压缩包大小不超过20M，格式为rar或者zip</span>
    </li>    --%>
        
	<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button class="submit" type="submit" OnClick="btnupfile_Click" Text=" 提交信息 " 
            runat="server" Width="131px" Font-Size="Large" Height="46px"/>
	</li>
	</ul>
	</form>
</body>
</html>
