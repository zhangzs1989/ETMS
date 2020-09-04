<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUserInfoManager.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.AdminUserInfoManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../DepartmentUI/css/style.css" rel="stylesheet" />
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
        <span style="font-size:20px">选择所在部门：</span> <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#99FF33" Font-Size="Larger" Height="24px" Width="272px" DataSourceID="admindepartmentinfoconn" DataTextField="Danwei" DataValueField="Danwei" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        <asp:SqlDataSource ID="admindepartmentinfoconn" runat="server" ConnectionString="<%$ ConnectionStrings:admindepartmentinfoconn %>" SelectCommand="SELECT [Danwei] FROM [DanweiInfo]"></asp:SqlDataSource>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" Width="1082px" Height="473px" OnRowCreated="GridView1_RowCreated" ForeColor="Black" OnPageIndexChanging="GridView1_PageIndexChanging" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="ID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="操作" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerSettings Mode="NumericFirstLast" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
