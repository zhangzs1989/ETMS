<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanxunjw.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Usercanxunjw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="place">
    <span>位置：</span>
    <ul class="placeul">
    <li><a href="#">培训情况查询</a></li>
    <li><a href="#">局外个人参训统计</a></li>
    </ul>
    </div>
    <div>
         <table>
        <tr><td align="center" style=" word-break:break-all">
             <asp:Panel ID="Panel1" runat="server" Width="100%">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="mydbjwconn" GridLines="Vertical" Height="382px" Width="1095px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:TemplateField HeaderText="编号">
                     <ItemTemplate>
                          <%#Container.DataItemIndex+1 %>
                     </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Trainname" HeaderText="培训名称" SortExpression="Trainname" />
                    <asp:BoundField DataField="Trainfangshi" HeaderText="培训方式" SortExpression="Trainfangshi" />
                    <asp:BoundField DataField="Trainzhuban" HeaderText="培训主办" SortExpression="Trainzhuban" />
                    <asp:BoundField DataField="Traintime" HeaderText="培训时间" SortExpression="Traintime" />
                    <asp:BoundField DataField="Trainxueshi" HeaderText="培训学时" SortExpression="Trainxueshi" />
                    

                    <%--<asp:BoundField DataField="ID" HeaderText="ID编号" InsertVisible="False" ReadOnly="True" SortExpression="ID" />--%>
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Showjwtrain.aspx?ID={0}"
                        HeaderText="详细信息" Text="查看" /> 
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <asp:SqlDataSource ID="mydbjwconn" runat="server" ConnectionString="<%$ ConnectionStrings:mydbjwconn %>" SelectCommand="SELECT [Trainname], [Trainfangshi], [Trainzhuban], [Traintime], [Trainxueshi], [ID] FROM [TrainInfo] WHERE ([Username] = @Username)">
                <SelectParameters>
                    <asp:SessionParameter Name="Username" SessionField="userloginname" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
                  </asp:Panel>
            </td></tr></table>
    </div>
        <asp:Button ID="bttoexcel" runat="server" Text="导出此表" BackColor="#999999" Height="32px" OnClick="bttoexcel_Click" />
        <h6 style="font-size:small">提示:您局外培训共获得<%=jwxf %>学分。</h6>
    </form>
</body>
</html>
