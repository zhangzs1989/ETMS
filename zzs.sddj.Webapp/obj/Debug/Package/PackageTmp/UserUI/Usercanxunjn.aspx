<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanxunjn.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Usercanxunjn" %>

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
    <li><a href="#">局内个人参训统计</a></li>
    </ul>
    </div>
        <div>

            <table>
        <tr><td align="center" style=" word-break:break-all">
            <asp:GridView ID="GridView1" HeaderStyle-Width="8%" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" Height="200px" Width="500px" EmptyDataText="无培训记录">
                <Columns>
                    <asp:TemplateField HeaderText="编号">
                     <ItemTemplate>
                          <%#Container.DataItemIndex+1 %>
                     </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Trainname" HeaderText="培训名称" SortExpression="Trainname" />
                    <asp:BoundField DataField="Trainzhuban" HeaderText="培训主办" SortExpression="Trainzhuban" />
                    <asp:BoundField DataField="Traintime" HeaderText="培训时间" SortExpression="Traintime" />
                    <asp:BoundField DataField="Trainxueshi" HeaderText="培训学时" SortExpression="Trainxueshi" />
                    <asp:BoundField DataField="Traindidian" HeaderText="培训地点" SortExpression="Traindidian" />
                
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Showjntrain.aspx?ID={0}"
                        HeaderText="详细信息" Text="查看" /> 
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:mydbjnconn %>" SelectCommand="SELECT [Trainname], [Traindidian], [Traintime], [Trainxueshi], [Trainjianjie], [Trainzhuban], [Trainbeizhu], [ID] FROM [JuneiTrain] WHERE ([Trainrenyuan] = @Trainrenyuan)">
                <SelectParameters>
                    <asp:SessionParameter Name="Trainrenyuan" SessionField="userloginname" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            </td></tr>
            
    </table>
            <br />
        </div>
        <asp:Button ID="bttoexcel" runat="server" Text="导出此表" BackColor="#999999" Height="32px" OnClick="bttoexcel_Click" />

        <h6 style="font-size:small">提示:您局内培训共获得<%=jnxf %>学分。</h6>
    </form>
</body>
</html>
