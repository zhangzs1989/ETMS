<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JuneitrainTj.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.JuneitrainTj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>局内培训提交</title>
    <%--<link href="css/demo.css" rel="stylesheet" />--%>
    <style type="text/css">
        .auto-style4 {
            width: 680px;
        }
        table,tr
        {
            border:1px none green;
            align-content:center;
            vertical-align:middle;
            text-align:center;
            
            
        }
        table
        {
            border-collapse:collapse;
            align-content:center;
           
        }

        .listboxcss{
            border:1px solid green;
            border-right-color:aqua;
            color:red;
            width:250px;
            border-left:-50px;

        }

        .auto-style7 {
            width: 462px;
            border:1px solid green;
            height: 150px;
        }

        .auto-style8 {
            height: 57px;
        }

        /*.auto-style9 {
            border-right: 1px solid aqua;
            color: red;
            width: 250px;
            left: 7px;
            top: -2px;
            height: 265px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: -50px;
            border-top-style: solid;
            border-top-color: inherit;
            border-top-width: 1px;
            border-bottom-style: solid;
            border-bottom-color: inherit;
            border-bottom-width: 1px;
        }*/

        .auto-style11 {
            width: 381px;
            border: 1px solid green;
            height: 36px;
        }
        .auto-style12 {
            width: 381px;
            border: 1px solid green;
            height: 35px;
        }

        .auto-style13 {
            width: 462px;
            border: 1px solid green;
            height: 93px;
        }

        .auto-style14 {
            height: 57px;
            width: 306px;
        }
        .auto-style15 {
            width: 306px;
        }

    </style>
</head>
<body style="height: 571px">
    <form id="form1" runat="server" action="JuneitrainInquiry.aspx" method="post">
        <table class="auto-style4">
            <tr><td class="auto-style14">培训人员（系统内在编）:      </td><td colspan="2" class="auto-style8">
                <asp:Button ID="Button4" runat="server" Text="选择参训人员" Height="33px" Width="102px" OnClick="Button4_Click" /></td></tr>
            <tr><td class="auto-style15">其 他 培 训 人 员    :  </td><td colspan="2"><textarea id="qitarenyuan" name="qitarenyuan" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style7"></textarea></td></tr>
            <tr><td class="auto-style15">培 训 班 名 称:</td><td colspan="2"><input type="text" id="peixunname" name="peixunname"  runat="server"  class="auto-style11"/></td></tr>
            <tr><td class="auto-style15">培 训 地 点   :</td><td colspan="2"><input type="text" id="peixundidian" name="peixundidian" runat="server" class="auto-style11"/></td></tr>
            <tr><td class="auto-style15">培 训 时 间   :</td><td colspan="2"><input type="text" id="peixuntime" name="peixuntime"  runat="server" class="auto-style12" /></td></tr>
            <%--<tr><td class="auto-style15">培 训 时 间   :</td><td colspan="2"><asp:TextBox ID="peixuntime" runat="server" CssClass="auto-style12"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" Operator="DataTypeCheck"  Type= "Date"></asp:CompareValidator></td></tr>--%>
            <tr><td class="auto-style15">培 训 学 时   :</td><td colspan="2"><input type="text" id="peixunxueshi" name="peixunxueshi"  runat="server" class="auto-style11" onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" /></td></tr>
            <tr><td class="auto-style15">培 训 简 介   :  </td><td colspan="2"><textarea id="peixunjianjie" name="peixunjianjie" runat="server" placeholder="此项内容必填，某些浏览器可能不显示*号" class="auto-style7"></textarea></td></tr>
            <tr><td class="auto-style15">备       注   :  </td><td colspan="2"><textarea id="jnbeizhu" name="jnbeizhu" runat="server"  class="auto-style13"></textarea></td></tr>
            
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="提交信息" Height="42px" Width="91px" OnClick="Button1_Click" /></td></tr>
                
        </table>
        
    </form>
</body>
</html>
