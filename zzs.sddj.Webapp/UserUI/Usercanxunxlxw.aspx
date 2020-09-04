<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanxunxlxw.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Usercanxunxlxw" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">培训情况查询</a></li>
    <li><a href="#">学历学位升级教育</a></li>
    </ul>
    </div>
   <div>

            <table>
        <tr><td align="center" style=" word-break:break-all">
            <asp:GridView ID="GridView1" HeaderStyle-Width="8%" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2" Height="321px" Width="1066px" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                   <asp:TemplateField HeaderText="编号">
                     <ItemTemplate>
                          <%#Container.DataItemIndex+1 %>
                     </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Leibie" HeaderText="升级类型" SortExpression="Leibie" />
                    <asp:BoundField DataField="Scool" HeaderText="学校" SortExpression="Scool" />
                    <asp:BoundField DataField="Major" HeaderText="专业" SortExpression="Major" />
                    <asp:BoundField DataField="StartTime" HeaderText="开始时间" SortExpression="StartTime" />
                    <asp:BoundField DataField="EndTime" HeaderText="结束时间" SortExpression="EndTime" />
                    <asp:BoundField DataField="Didian" HeaderText="地点" SortExpression="Didian" />
                    <%--<asp:BoundField DataField="Spzhuangtai" HeaderText="Spzhuangtai" SortExpression="Spzhuangtai" />--%>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="Black" HorizontalAlign="Center" BackColor="#999999" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:xlxwconn %>" SelectCommand="SELECT [ID], [Leibie], [Scool], [Major], [StartTime], [EndTime], [Didian], [Spzhuangtai] FROM [Xuelixuewei] WHERE ([Peixunren] = @Peixunren)">
                <SelectParameters>
                    <asp:SessionParameter Name="Peixunren" SessionField="userloginname" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td></tr>
            
    </table>
            <br />
        </div>
    </form>
</body>
</html>
