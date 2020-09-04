<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Juwaitrain.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Juwaitrain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <title>HTML5 Contact Form</title>
    <link rel="stylesheet" media="screen" href="styles.css" rel="external nofollow" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode", sans-serif;>
	<form class="contact_form" action="Juwaitrain.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>局外参训提交</h2>
         <span class="required_notification">* 表示必填项</span>
    </li>
    <li>
        <label for="name">培训班名称:</label>
        <input type="text" name="peixunname" required/>
    </li>
	<li>
        <label for="name">培训方式:</label>
        
        <!--<input type="text" name="name" required/>-->
        <select  class="peixunfangshi" name="peixunfangshi" style="font-size:13px">
        <option class="fangshifontcolor">中国地震局组织的培训 
        <option class="fangshifontcolor">省委组织的培训
        <option class="fangshifontcolor">省政府组织的培训 
        <option class="fangshifontcolor">上级干部选学活动
        <option class="fangshifontcolor">省局外的其他培训
         
        </select>
    </li>
	<li>
    <label for="email">培训主办机构:</label>
    <input type="text" name="peixunzhuban" required/>
    <span class="form_hint"></span>
	</li>
	<li>
    <label for="email">培训承办机构:</label>
    <input type="text" name="peixunchengban" required/>
    <span class="form_hint"></span>
	</li>
	<li>
    <label for="website">培训起止时间:</label>
    <input type="text" name="peixunshijian" required/>
    <span class="form_hint">格式：20160101-20170101</span>
	</li>
	<li>
        <label for="name">培训学时:</label>
        <input type="text" name="peixunxueshi" required/>
        <span class="form_hint">例：32</span>
        <%--<span style="color:red"><%=xueshimsg %></span>--%>
    </li>
    <li>
        <label for="name">培训地点:</label>
        <input type="text" name="peixundidian" required/>
    </li>
	<li>
    <label for="message">培训主要内容:</label>
    <textarea name="peixunneirong" rows="6" required placeholder="此项内容必填，某些浏览器可能不显示*号"></textarea>
	</li>
    <li>
        <label for="message">相关材料打包上传:</label>
    <!--<input type="file" name="shangchuanwenjian" style="border:1px solid gray;color:red;font:bold 12px '隶书';height:30px;width:300px"/>-->
        <asp:FileUpload ID="homeworkFile" runat="server" />
        <span class="form_hint">压缩包大小不超过20M，格式为rar或者zip</span>
        <!--<asp:Button ID="btndownfilebystream" runat="server" Text="上传" 
            OnClick="btnupfile_Click" Width="79px" />-->
    </li>    
        
	<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button class="submit" type="submit" OnClick="btnupfile_Click" Text="  提交信息" 
            runat="server" Width="131px" Font-Size="Large" Height="46px"/>
	</li>
	</ul>
	</form>
</body>
</html>
