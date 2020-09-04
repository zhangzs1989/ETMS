<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuelixuewei.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Xuelixuewei" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <title>学历学位申请</title>
    <link rel="stylesheet" media="screen" href="styles.css" rel="external nofollow" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode">
	<form id="Form1" class="contact_form" action="Xuelixuewei.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>学历学位升级教育申请</h2>
         <span class="required_notification">* 表示必填项</span>
    </li><br />
    <!--<li>
        <label for="name">名称：</label>
        <input type="text" name="peixunname" required/>
    </li>-->
	<li>
        <label for="name">升级类别:</label>
        
        <!--<input type="text" name="name" required/>-->
        <select  class="peixunfangshi" name="xlxwleibie" style="font-size:13px">
        <option class="fangshifontcolor">硕士 
        <option class="fangshifontcolor">博士
        </select>
    </li>
	<li>
    <label for="email">报考学校:</label>
    <input type="text" name="xlxwscool" required/>
    <span class="form_hint"></span>
	</li>
    <li>
    <label for="message">就读专业:</label>
    <input type="text" name="xlxwmajor" required/>
	</li>
	<!--<li>
    <label for="email">培训承办机构:</label>
    <input type="text" name="peixunchengban" required/>
    <span class="form_hint"></span>
	</li>-->
	<li>
    <label for="website">开始时间:</label>
    <input type="text" name="xlxwstarttime" required/>
    <span class="form_hint">格式：20160101</span>
	</li>
    <li>
    <label for="website">终止时间:</label>
    <input type="text" name="xlxwendtime" required/>
    <span class="form_hint">格式：20170101</span>
	</li>
	<!--<li>
        <label for="name">培训学时:</label>
        <input type="text" name="peixunxueshi" required/>
    </li>-->
    <li>
        <label for="name">就读地点:</label>
        <input type="text" name="xlxwdidian" required/>
    </li>
	<li>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2" class="submit" type="submit" OnClick="xlxw_Click" Text="提交信息" 
            runat="server" Width="198px"/>
	</li>
	</ul>
	</form>
</body>
</html>
