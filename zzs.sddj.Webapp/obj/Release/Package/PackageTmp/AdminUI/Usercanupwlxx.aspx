<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usercanupwlxx.aspx.cs" Inherits="zzs.sddj.Webapp.UserUI.Usercanupwlxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--<script type="text/javascript">
        function BrowseFolder() {
                  try {
                      var Message = "请选择文件夹";
                      var Shell = new ActiveXObject("Shell.Application");
                      var Folder = Shell.BrowseForFolder(0, Message, 0x0040, 0x11); //起始目录为：我的电脑
                      if (Folder != null) {
                          Folder = Folder.items(); // 返回 FolderItems 对象
                          Folder = Folder.item();
                         Folder = Folder.Path; // 返回路径
                         if (Folder.charAt(Folder.length - 1) != "\\") {
                             Folder = Folder + "\\";
                         }
                         var bb = document.getElementByIdx_x("<%=txtBackupPath.ClientID%>");     
                         //document.getElementByIdx_x("BackupPath").value = Folder;
                        bb.value = Folder;
                         return Folder;
                     }
                 } catch (e) {
                     alert(e.message);
                 }
             }
    </script>--%>
     
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr><td>年度：<input id="Text1" type="text" /></td></tr>
            <tr><td>网络学习表格上传：<asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="BtnUp" runat="server" onclick="BtnUp_Click" Text="上 传" />
    <asp:Label ID="LabMsg" runat="server"></asp:Label></td></tr>
            <tr><td>
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td></tr>
        </table>
    </div>
        
   <%-- <div>
        <asp:TextBox runat="server" ID="txtBackupPath"  Width="488px">D:\上传\Data\Data</asp:TextBox> 
         <asp:Button  runat="server" Text="浏览..." Width="78px" OnClientClick="BrowseFolder()" OnClick="Unnamed1_Click"/>
    </div>--%>



    </form>
</body>
</html>
