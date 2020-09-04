<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoAdmin.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.UserInfoAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AllowSorting="true" AutoGenerateColumns="false" >
      
                        <Columns>

                            <asp:BoundField DataField="username" HeaderText="用户姓名" />

                            <asp:BoundField DataField="userpwd" HeaderText="密码" />

                            <asp:CommandField HeaderText="edit" ShowEditButton="True" />

                            <asp:CommandField HeaderText="delete" ShowDeleteButton="True" />

                        </Columns>

                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" 
                ForeColor="White" />

                        <PagerStyle BackColor="White" ForeColor="Black" 
                HorizontalAlign="Right" />

                        <HeaderStyle BackColor="#333333" Font-Bold="True" 
                ForeColor="White" />
        
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
