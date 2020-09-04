<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JnManager.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.JnManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>本部门组织培训情况</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $(".click").click(function () {
            $(".tip").fadeIn(200);
        });

        $(".tiptop a").click(function () {
            $(".tip").fadeOut(200);
        });

        $(".sure").click(function () {
            $(".tip").fadeOut(100);
        });

        $(".cancel").click(function () {
            $(".tip").fadeOut(100);
        });

    });
</script>
    <style type="text/css">
        .auto-style3 {
            width: 191px;
            height: 26px;
        }
    </style>
</head>


<body>
    <form runat="server">
    <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">局内培训管理</a></li>
    <li><a href="#">局内组织培训情况</a></li>
    </ul>
    </div>
    <%--选择查看部门：
            <select id="Select1" runat="server">
                <option>山东省地震局</option>
                <option>办公室</option>
                <option>人事教育处</option>
                <option>发展与财务处</option>
                <option>科学技术处</option>
                <option>监测预报处</option>
                <option>震害防御处</option>
                <option>应急救援处</option>
                <option>纪检监察审计处</option>
                <option>机关党委</option>
                <option>离退休干部处</option>
                <option>财务室</option>
                <option>宣传教育中心</option>
                <option>地震预报研究中心</option>
                <option>地震台网中心</option>
                <option>地震监测中心</option>
                <option>工程地震研究中心</option>
                <option>地震应急保障中心</option>
                <option>基建办</option>
                <option>地震应急救援中心</option>
                <option>泰安基准地震台</option>
                <option>聊城地震水化试验站</option>
                <option>青岛地震台</option>
                <option>烟台地震监测中心台</option>
                <option>长岛地震台</option>
                <option>莱阳地震台</option>
                <option>潍坊地震监测中心台</option>
                <option>昌邑地震台</option>
                <option>安丘地震台</option>
                <option>临沂地震监测中心台</option>
                <option>郯城马陵山地震台</option>
                <option>苍山地震台</option>
                <option>相公庄地震台</option>
                <option>沂水地震台</option>
                <option>菏泽地震监测中心台</option>
                <option>牛岚地震台</option>
                <option>嘉祥地震监测中心台</option>
                <option>邹城地震台</option>
                <option>德州地震台</option>
                <option>五莲地震台</option>
                <option>陵阳地震台</option>
                <option>大山地震台</option>                
                 <option>荣成地震台</option>
        </select>
        <asp:Button ID="btn_click" runat="server" Text="点击查看" OnClick="btn_click_Click" />
    <div class="rightinfo">        --%>
        <table class="tablelist">
         <tr>  
        <!--<th><input name="" type="checkbox" value="" checked="checked"/></th>-->
        <th style="text-align:center">编号<i class="sort"><!--<img src="images/px.gif" />--></i></th>
        <th style="text-align:center">培训班名称</th>
        <th style="text-align:center">培训地点</th>
        <th style="text-align:center">培训时间</th>
        <th style="text-align:center">培训学时</th>
        <th style="text-align:center">培训主办</th>
        <%--<th style="text-align:center">审批状态</th>--%>
        <th style="text-align:center">操作</th>
        </tr>
        <%=StrHtml%>
        
    </table>
    
   <div class="pages">
           
                   <a href="JnManager.aspx?pageindex=1"> 首页</a>  | <a href="JnManager.aspx?pageindex=<%=Pageindex-1 %>"> 前页 </a>  | 
                    

                      <a href="JnManager.aspx?pageindex=<%=Pageindex+1 %>">后页</a> |  <a href="JnManager.aspx?pageindex=<%=Pagecounts %>"> 尾页 </a>   | 页次 <%=Pageindex %>/<%=Pagecounts %>页
                    <hr />
                   
  </div>
    <div class="tip">
    	<div class="tiptop"><span>提示信息</span><a></a></div>
        
      <div class="tipinfo">
        <span><img src="images/ticon.png" /></span>
        <div class="tipright">
        <p>是否确认对信息的修改 ？</p>
        <cite>如果是请点击确定按钮 ，否则请点取消。</cite>
        </div>
        </div>
        
        <div class="tipbtn">
        <input name="" type="button"  class="sure" value="确定" />&nbsp;
        <input name="" type="button"  class="cancel" value="取消" />
        </div>
    
    </div>
 
    </div>
    
    <script type="text/javascript">
        $('.tablelist tbody tr:odd').addClass('odd');
	</script>
    
    </form>
	
</body>
</html>

