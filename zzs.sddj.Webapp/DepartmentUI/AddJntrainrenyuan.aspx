<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJntrainrenyuan.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.AddJntrainrenyuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        /*td
        {
            border:1px none green;
            align-content:center;
            vertical-align:middle;
            text-align:center; 
        }*/
       .table tr  td{ border:1px #ff000 solid
                         
       }
       td{
           text-align:center;
       }
     </style>   
</head>
<body>
    <form id="form1" runat="server">
        <%--<table>
            <tr><td rowspan="2"> <asp:TreeView ID="TreeView1"  runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" Width="221px">
   </asp:TreeView></td></tr>
            <tr><td rowspan="2"><asp:ListBox ID="ListBox1" runat="server" Height="225px" Width="265px" SelectionMode="Single"></asp:ListBox></td></tr>
            <tr><td><asp:Button ID="Button2" runat="server" OnClick="btn02_Click" Text="删除"/></td><td><asp:Button ID="Button3" runat="server" OnClick="btn02_Click" Text="删除"/></td></tr>
            <tr><td rowspan="2"><asp:ListBox ID="ListBox2" runat="server"></asp:ListBox></td></tr>
        </table>--%>
   <table border="1">
       <tr><td rowspan="2">选择人员部门：<br /><asp:TreeView ID="TreeView1"  runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" Width="221px">
   </asp:TreeView></td></tr>
       <tr><td rowspan="1"><asp:ListBox ID="ListBox1" runat="server" Height="225px" Width="265px" SelectionMode="Multiple"></asp:ListBox></td><td><asp:Button ID="Button2" runat="server" OnClick="btn02_Click" Text="添加->"/></td><td><asp:Button ID="Button1" runat="server" OnClick="btnremove" Text="<-删除"/></td><td><asp:ListBox ID="ListBox2" runat="server" Height="225px" Width="265px" SelectionMode="Multiple"></asp:ListBox></td></tr>
      <tr><td colspan="5" class="auto-style5">
          <asp:Button ID="Button3" runat="server" Text="提交人员" Height="40px" Width="87px" OnClick="Button3_Click" /></td></tr>
   </table>
    </form>
</body>
</html>