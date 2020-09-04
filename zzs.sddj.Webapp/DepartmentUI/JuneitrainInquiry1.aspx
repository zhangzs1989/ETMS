<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JuneitrainInquiry1.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.JuneitrainInquiry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title>局内培训提交</title>
    <link href="css/demo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" accept="JuneitrainInquiry.aspx" method="post">
    <div>
        <li>
         <h2>局外参训提交</h2>
         <span class="required_notification">* 表示必填项</span>
        </li>
        <li>
        <label for="name">培训班名称:</label>
        <input type="text" name="peixunname" required/>
    </li>
        <li>
    <label for="website">培训起止时间:</label>
    <input type="text" name="peixunshijian" required/>
    <span class="form_hint">格式：20160101-20170101</span>
	</li>
        <li>
        <label for="name">培训学时:</label>
        <input type="text" name="peixunxueshi" required/>
    </li>
        <li>
        <label for="name">培训地点:</label>
        <input type="text" name="peixundidian" required/>
    </li>
        <li>
    <label for="message">培训主要内容:</label>
    <textarea name="peixunneirong" rows="6" cols="50" required placeholder="此项内容必填，某些浏览器可能不显示*号"></textarea>
	</li>
         
        <li>
            <label for="message">培训人员名单:</label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="mydb_danweiinfo" DataTextField="Danwei" DataValueField="Danwei" AppendDataBoundItems="true" AutoPostBack="True"></asp:DropDownList>
        <asp:SqlDataSource ID="mydb_danweiinfo" runat="server" ConnectionString="<%$ ConnectionStrings:mydbConnectionString %>" SelectCommand="SELECT [Danwei] FROM [DanweiInfo]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            
        </li>
        
</div>
        
        <table>  
        <tr>  
            <td align="center">  
                <asp:ListBox ID="leftListBox"  CssClass="marquee_centent" runat="server" SelectionMode="Multiple" BackColor="White" Font-Size="Medium" AutoPostBack="True" Font-Italic="False" ForeColor="#FF3300" >  
                
                </asp:ListBox>  
            </td>  
            <td align="center">  
                <asp:Button ID="btnLeftToRight" runat="server" Text="右移" Width="132px" /><br />  
                <asp:Button ID="btnRightToLeft" runat="server" Text="左移" Width="132px" /><br />  
                <asp:Button ID="btnRightUp" runat="server" Text="全选" Width="132px"/><br />  
                <asp:Button ID="btnRightDown" runat="server" Text="清空" Width="132px"/><br />  
            </td>  
            <td align="center">  
                <asp:ListBox ID="rightListBox" runat="server" SelectionMode="Multiple">  
                </asp:ListBox>  
            </td>  
        </tr>  
    </table>  
    </form>
</body>
</html>
