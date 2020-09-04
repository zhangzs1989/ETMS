<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xlxwdengji.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Xlxwdengji" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>学历学位登记</title>
    <link rel="stylesheet" media="screen" href="css/styles.css" rel="external nofollow" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            border-bottom-color: Gray;
            padding: 6px;
            border: 1px solid #C0C0C0;
            width: 131px;
            height: 33px;
            clip: rect(0px,181px,18px,0px);
            overflow: hidden;
            left: 10px;
            top: -6px;
        }
        .auto-style2 {
            width: 152px;
        }
        .auto-style3 {
            width: 113px;
        }
        .auto-style4 {
            width: 232px;
        }
        .auto-style5 {
            width: 241px;
        }
    </style>
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode">
	<form id="Form1" class="contact_form" action="Xlxwdengji.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
	<ul>
    <li>
         <h2>学历学位升级教育申请</h2>
    </li><br />
    <!--<li>
        <label for="name">名称：</label>
        <input type="text" name="peixunname" required/>
    </li>-->
	<li>
        <label for="name">升级类别:</label>
        
        <!--<input type="text" name="name" required/>-->
        <select  class="auto-style1" name="xlxwleibie" style="font-size:13px">
       
        <option class="fangshifontcolor">硕士 </option>
        <option class="fangshifontcolor">博士</option>
        </select>
    </li>
         <li>
    <label for="email">申请人姓名:</label>
    <input type="text" name="xlxwren" required/>
    <span class="form_hint"></span>
	</li>

	<li>
    <label for="email">报考学校:</label>
    <input type="text" name="xlxwscool" required class="auto-style2"/>
    <span class="form_hint"></span>
	</li>
    <li>
    <label for="message">就读专业:</label>
    <input type="text" name="xlxwmajor" required class="auto-style3"/>
	</li>
	<!--<li>
    <label for="email">培训承办机构:</label>
    <input type="text" name="peixunchengban" required/>
    <span class="form_hint"></span>
	</li>-->
	<li>
    <label for="website">开始时间:</label>
    <input type="text" name="xlxwstarttime" onkeyup="this.value=this.value.replace(/\D/g,'')" class="auto-style4" />
    <span class="form_hint">&nbsp;&nbsp; 格式：201601</span>
	</li>
    <li>
    <label for="website">终止时间:</label>
    <input type="text" name="xlxwendtime" onkeyup="this.value=this.value.replace(/\D/g,'')" class="auto-style5"  />
        <span class="form_hint">&nbsp;&nbsp; 格式：201701</span>
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
