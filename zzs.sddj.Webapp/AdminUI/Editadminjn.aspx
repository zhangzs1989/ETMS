<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editadminjn.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Editadminjn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <title>HTML5 Contact Form</title>
    <link rel="stylesheet" media="screen" href="styles.css" rel="external nofollow" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 542px;
            height: 211px;
        }
        .auto-style3 {
            width: 552px;
            height: 211px;
        }
        .auto-style4 {
            width: 543px;
            height: 211px;
        }
        </style>
    <script type="text/javascript">
        function checkniandu()
        {
            var niandu = document.getElementById("peixunniandu").value;
            if (niandu.length == 0) {
                alert("请输入培训年度...");
            }

        }
            function checkname()
            {
                var peixunname = document.getElementById("peixunname").value;
                if (peixunname.length== 0) {
                    alert("请输入培训名称...");
                } 
            }
        
            function checkdidian()
            {
                var peixundidian = document.getElementById("peixundidian").value;
               if (peixundidian.length== 0) {
                    alert("请输入培训地点...")
                }
            }

            function checktime()
            {
                var peixuntime = document.getElementById("peixuntime").value;
              if (peixuntime.length== 0) {
                    alert("请输入培训时间...")
                } 
                
                
            }
           function checkxueshi()
            {
                var peixunxueshi = document.getElementById("peixunxueshi").value;
                if (peixunxueshi.length==0) {
                    alert("请输入培训学时...")
                }
            }     
    </script>
</head>
<body font:"14px/21px","Lucida Sans", "Lucida Grande", "Lucida Sans Unicode", sans-serif;>
    <form class="contact_form" action="Editadminjn.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
        <%--<table class="auto-style4">
            <tr><td class="auto-style14">培训人员（系统内在编）:      </td><td colspan="2" class="auto-style8">
                <asp:Button ID="Button4" runat="server" Text="选择参训人员" Height="33px" Width="102px" OnClick="Button4_Click" /></td></tr>
            <tr><td class="auto-style15">其他培训人员及所在单位： <span style="color:Red">（其他人员为局机关，驻济各单位，各直属台站、各代管台站以外的参训人员）</span>&nbsp;  </td><td colspan="2"><textarea id="qitarenyuan" name="qitarenyuan" runat="server" placeholder="其他人员为局机关，驻济各单位，各直属台站、各代管台站以外参训人员" class="auto-style7"></textarea></td></tr>
            <tr><td class="auto-style15">培 训 年 度:</td><td colspan="2"><input type="text" id="peixunniandu" name="peixunniandu"  runat="server"  class="auto-style11" maxlength="4" onkeyup="this.value=this.value.replace(/\D/g,'')" onfocus="javascript:if(this.value=='请输入内容')this.value='';"/></td></tr>
            <tr><td class="auto-style15">培 训 班 名 称:</td><td colspan="2"><input type="text" id="peixunname" name="peixunname"  runat="server"  class="auto-style11"/></td></tr>
            <tr><td class="auto-style15">培 训 地 点   :</td><td colspan="2"><input type="text" id="peixundidian" name="peixundidian" runat="server" class="auto-style11"/></td></tr>
            <tr><td class="auto-style15">培 训 时 间   :</td><td colspan="2"><input type="text" id="peixuntime" name="peixuntime"  runat="server" class="auto-style12" /></td></tr>
            <tr><td class="auto-style15">培 训 学 时   :<span style="color:Red">(如有请假等情况，请在备注栏内说明参训人员实际培训学时。)</span></td><td colspan="2"><input type="text" id="peixunxueshi" name="peixunxueshi"  runat="server" class="auto-style11" onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" /></td></tr>            
            <tr><td class="auto-style15">培 训 简 介   :  </td><td colspan="2"><textarea id="peixunjianjie" name="peixunjianjie" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style7"></textarea></td></tr>
            <tr><td class="auto-style15">备       注   :  </td><td colspan="2"><textarea id="jnbeizhu" name="jnbeizhu" runat="server"  class="auto-style13"></textarea></td></tr>
            
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="提交信息" Height="42px" Width="91px" OnClick="Button1_Click" /></td></tr>
                
        </table>--%>
        <ul>
        <li>
             <h2>局内参训提交</h2>
             <%--<span class="required_notification">* 表示必填项</span>--%>
        </li>
        <li>
        <label for="name">新增培训人员:</label>
        <input type="text" id="addname" name="addname"  runat="server"/>
            <span class="form_hint">姓名请用中文 、分隔。</span>
        </li>
        <%--<li>
        <label for="message">其他培训人员及所在单位：</label>
        <textarea id="peixunren" name="peixunren" runat="server" class="auto-style3" placeholder="其他人员为局机关，驻济各单位，各直属台站、各代管台站以外参训人员"></textarea>
        <span class="form_hint"></span>
        </li>--%>
	    <li>
        <label for="name">培 训 年 度:</label>
        <input type="text" id="peixunniandu" name="peixunniandu"  runat="server" maxlength="4" onkeyup="this.value=this.value.replace(/\D/g,'')" onfocus="javascript:if(this.value=='请输入内容')this.value='';" />
        
        <span class="form_hint"></span>

	    </li>
	    <li>
        <label for="email">培 训 班 名 称:</label>
        <input type="text" id="peixunname" name="peixunname"  runat="server"/>
        <span class="form_hint"></span>
	    </li>
         <li>
        <label for="email">培 训 主 办:</label>
        <input type="text" id="peixunzhuban" name="peixunzhuban"  runat="server"/>
        <span class="form_hint"></span>
	    </li>
	    <li>
        <label for="email">培 训 地 点   :</label>
        <input type="text" id="peixundidian" name="peixundidian" runat="server"/>
        <span class="form_hint"></span>
	    </li>
        <li>
        <label for="email">培 训 时 间   :</label>
        <input type="text" id="peixuntime" name="peixuntime"  runat="server"/>
        <span class="form_hint"></span>
	    </li>
	    <li>
        <label for="name">培 训 学 时:</label>
        <input type="text" id="peixunxueshi" name="peixunxueshi" runat="server" onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" />
        <span class="form_hint"></span>
        <%--<span style="color:red"><%=xueshimsg %></span>--%>
        </li>
            <li>
            <label for="message">局 内 培 训 人 员   :</label>
            <textarea id="peixunrenyuan" name="peixunrenyuan" runat="server" disabled="disabled" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style4"></textarea>
        </li>
            <li>
            <label for="message">局 外 培 训 人 员   :</label>
            <textarea id="jwrenyuan" name="jwrenyuan" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style4"></textarea>
        </li>
        <li>
            <label for="message">培 训 简 介   :</label>
            <textarea id="peixunjianjie" name="peixunjianjie" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style4"></textarea>
        </li>
	    <li>
        <label for="message">备 注 :</label>
        <textarea id="peixunbeizhu" name="jnbeizhu" runat="server"  class="auto-style1"></textarea>
	    </li>
    
	<li>
        <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <%--<asp:Button ID="Button1" runat="server" Text="提交信息" Height="42px" Width="91px" OnClick="Button1_Click" />--%>
        <asp:Button class="submit" type="submit" OnClick="Button1_Click" Text="更新培训信息" 
            runat="server" Width="135px" Font-Size="Small" Height="46px"/>
    </li>
	</ul>
    </form>
</body>
</html>
