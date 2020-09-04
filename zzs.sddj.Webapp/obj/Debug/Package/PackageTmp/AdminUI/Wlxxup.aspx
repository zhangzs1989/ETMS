<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wlxxup.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.Wlxxup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>制度规定</title>
   <meta charset="utf-8">
    <link rel="stylesheet" media="screen" href="styles.css"/>
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" class="contact_form" action="Wlxxup.aspx" method="post" name="contact_form" enctype="multipart/form-data" runat="server">
        <ul>
        <li>
            <label for="name">网络学时年度:</label>
            <input type="text" id="wlxstext" runat="server" name="zhiduname" onkeyup="this.value=this.value.replace(/\D/g,'')" required/>
        </li>
        <li>
        <label for="message">相关材料打包上传:</label>
            <label for="message">有关制度文件上传:</label>
             <input id="homeworkFile" type="file" runat="server" />  
         </li>  
        <li>
            <!--<button class="submit" type="submit" onclick="btnupfile_Click">提交</button>-->
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnupfile_Click" runat="server" Text="提交信息" Width="150px" Font-Size="Medium" Height="30px" OnClick="btnupfile_Click_Click" />
	    </li>

        <%--<table>
            <tr><td>网络学时年度:</td><td><input id="wlxstext" type="text" runat="server" onkeyup="this.value=this.value.replace(/\D/g,'')" /></td></tr>
            <tr><td>上传网络学时Excel表格：</td><td><asp:FileUpload ID="homeworkFile" runat="server" Height="33px" /></td></tr>
            <tr><td rowspan="2">
                
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
            </td></tr>
        </table>--%>
        </ul>
    </form>
</body>
</html>
