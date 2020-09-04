<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="zzs.sddj.Webapp.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style4
        {
            height: 34px;
        }
        .buttoncss
        {}
        .style5
        {
            height: 37px;
            width: 111px;
            color:White;
        }
        .style6
        {
            height: 37px;
        }
        .style9
        {
            height: 10px;
            width: 111px;
        }
        .style13
        {
            height: 37px;
            width: 274px;
        }
        .style15
        {
            width: 274px;
        }
        #Button2
        {
            margin-left: 54px;
            height: 34px;
            width: 49px;
        }
        #Text1
        {
            height: 31px;
            width: 175px;
        }
        #Text2
        {
            height: 28px;
            width: 175px;
        }
        #Text3
        {
            height: 30px;
            width: 175px;
        }
        .style16
        {
            height: 34px;
            width: 111px;
        }
        .style17
        {
            height: 34px;
            width: 274px;
        }
        #Button1
        {
            height: 32px;
            width: 52px;
        }
        .style18
        {
            width: 111px;
        }
        .style19
        {
            height: 36px;
            width: 111px;
            color:White;
        }
        .style20
        {
            height: 36px;
            width: 274px;
            color:White;
        }
        .style21
        {
            height: 36px;
        }
        
    </style>
    <script>
        window.onload = function () {
            var url = document.getElementById("url");
            url.onclick = function () {
                var src = document.getElementById("imgcode").src;
                document.getElementById("imgcode").src = src + "?d" + new Date().getMilliseconds();
            }
        }
    </script>
</head>
<body>
    
<div><input id="__EVENTTARGET" type="hidden"> <input id="__EVENTARGUMENT" type="hidden"> <input id="__VIEWSTATE"
type="hidden" value="/wEPDwUKLTMxMzU2OTkzM2QYAQUeX19Db250cm9sc1JlcXVpcmVQb3N0QmFja0tleV9fFgEFA2J0bmF2stSMyj1cbWFEH2tzan/b7XAS" 
name="__VIEWSTATE"> </div>
<script type="text/javascript">
<!--
    var theForm = document.forms['form1'];
    if (!theForm) {
        theForm = document.form1;
    }
    function __doPostBack(eventTarget, eventArgument) {
        if (!theForm.onsubmit || (theForm.onsubmit() != false)) {
            theForm.__EVENTTARGET.value = eventTarget;
            theForm.__EVENTARGUMENT.value = eventArgument;
            theForm.submit();
        }
    }
// -->
</script>

<script src="login_files/WebResource.axd" type="text/javascript"></script>

<script src="login_files/WebResource(1).axd" type="text/javascript"></script>

<script src="login_files/ScriptResource.axd" type="text/javascript"></script>

<script src="login_files/ScriptResource(1).axd" type="text/javascript"></script>

<script type="text/javascript">
<!--
    function WebForm_OnSubmit() {
        if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) return false;
        return true;
    }
// -->
</script>

<script type="text/javascript">
//<![CDATA[
    //Sys.WebForms.PageRequestManager._initialize('ScriptManager1', document.getElementById('form1'));
    //Sys.WebForms.PageRequestManager.getInstance()._updateControls(['tUpdatePanel1'], [], [], 90);
//]]>
</script>

<div id="UpdatePanel1">
<div id="div1" style="left: 0px; position: absolute; top: 0px; background-color: #0066ff"></div>
<div id="div2" style="left: 0px; position: absolute; top: 0px; background-color: #0066ff"></div>
<script language="javascript">
    var speed = 20;
    var temp = new Array();
    var clipright = document.body.clientWidth / 2, clipleft = 0
    for (i = 1; i <= 2; i++) {
        temp[i] = eval("document.all.div" + i + ".style");
        temp[i].width = document.body.clientWidth / 2;
        temp[i].height = document.body.clientHeight;
        temp[i].left = (i - 1) * parseInt(temp[i].width);
    }
    function openit() {
        clipright -= speed;
        temp[1].clip = "rect(0 " + clipright + " auto 0)";
        clipleft += speed;
        temp[2].clip = "rect(0 auto auto " + clipleft + ")";
        if (clipright <= 0)
            clearInterval(tim);
    }
    tim = setInterval("openit()", 100);
</script>

<div>&nbsp;&nbsp; </div>
<div>
<form id="form1" runat="server">
<table  cellspacing="0" cellpadding="0" width="900" align="center" border="0">
  <tbody>
  <tr>
    <td style="height: 105px"><img src="login_files/login_1.gif" 
  border="0" alt="图片下载失败" /></td></tr>
  <tr>
    
    <td background="login_files/login_2.jpg">
      <table height="300" cellpadding="0" width="900" border="0">
        <tbody>
        <tr>
          <td colspan="2" height="35"></td></tr>
        <tr>
          <td width="360">
              <br />
              <br />
              <br />
              <br />
              <br />
              <br />
              <br />
              <br />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="Help.html" style="text-decoration:none">联系方式</a>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;版权：山东省地震局人事教育处</p>
            </td>
          <td>
            <table cellspacing="0" cellpadding="2" border="0">
              <tbody>
              <tr>
                <td class="style19">登 录 名:</td>
                <td class="style20">
                    <input id="Text1" type="text" name="txtName" placeholder="个人姓名"/></td>
                <td width=370 class="style21"><span 
                  id="RequiredFieldValidator3" 
                  style="FONT-WEIGHT: bold; VISIBILITY: hidden; COLOR: white">请输入登录名</span></td></tr>
              <tr>
                <td class="style5">密&nbsp; 码 :</td>
                <td class="style13">
                    <input id="Text2" type="password" name="txtPwd"/></td>
                <td class="style6"><span id="RequiredFieldValidator4" 
                  style="FONT-WEIGHT: bold; VISIBILITY: hidden; COLOR: white">请输入密码</span></td></tr>
              <tr>
                <td class="style5">验 证 码:&nbsp;
                <td class="style13"><%=msg%>
                    <input id="Text3" type="text" name="txtcode"/></td></td>
                <td class="style6"><img src="Validatecode.ashx" id="imgcode"/><a href="javascript:void(0)" id="url" style="color:Red">看不清，换一张</a></td></tr>
                
                <tr>
                    <td align="center" class="style18">
                    </td>
                </tr>

              <tr>
                <td class="style16"></td>
                <td class="style17">
                    <input id="Radio1" type="radio" name="check1" value="zhigong" checked="checked"/><label for="Radio1" class="style5">职工&nbsp; </label><input id="Radio3" type="radio" name="check1" value="partment"/><label for="Radio3" class="style5">部门</label>&nbsp; <input id="Radio2" type="radio" name="check1" value="admin"/><label for="Radio2" class="style5">管理员</label></td>
                <td class="style4">
                    </td>
                  </tr>

                  <tr>
        <td align="center" class="style9">
            </td>
    </tr>


              <tr>

                <td class="style18"></td>
                <td class="style15">
                    &nbsp;&nbsp;<input id="btn" 
                  style="border-width: 0px; width: 95px; height: 31px;" type="image" src="login_files/login_button.gif" name="btn" onclick="form1.submit()" /></td><td>
                      &nbsp;</td>
                  &nbsp;</tr>       
              </tbody></table></td></tr></tbody></table></td></tr>
  <tr>
    <td><img src="login_files/login_3.jpg" 
border=0></td></tr></tbody></table></div></div>

<script type="text/javascript">
<!--
    var Page_Validators = new Array(document.getElementById("RequiredFieldValidator3"), document.getElementById("RequiredFieldValidator4"));
// -->
</script>

<script type="text/javascript">
<!--
    var RequiredFieldValidator3 = document.all ? document.all["RequiredFieldValidator3"] : document.getElementById("RequiredFieldValidator3");
    RequiredFieldValidator3.controltovalidate = "txtName";
    RequiredFieldValidator3.evaluationfunction = "RequiredFieldValidatorEvaluateIsValid";
    RequiredFieldValidator3.initialvalue = "";
    var RequiredFieldValidator4 = document.all ? document.all["RequiredFieldValidator4"] : document.getElementById("RequiredFieldValidator4");
    RequiredFieldValidator4.controltovalidate = "txtPwd";
    RequiredFieldValidator4.evaluationfunction = "RequiredFieldValidatorEvaluateIsValid";
    RequiredFieldValidator4.initialvalue = "";
// -->
</script>

<div><input id="__EVENTVALIDATION" type="hidden" value="/wEWBQKHmOW2AwLEhISFCwKd+7qdDgLChPy+DQKSoqqWDwNN1E3vW0gpbdtBgVWKbj2bcHhs" name="__EVENTVALIDATION"> </div>
<script type="text/javascript">
<!--
    var Page_ValidationActive = false;
    if (typeof (ValidatorOnLoad) == "function") {
        ValidatorOnLoad();
    }

    function ValidatorOnSubmit() {
        if (Page_ValidationActive) {
            return ValidatorCommonOnSubmit();
        }
        else {
            return true;
        }
    }
// -->
</script>

<%--<script type="text/javascript">
<!--
    Sys.Application.initialize();
// -->
</script>--%>
    </form>
</body>
</html>