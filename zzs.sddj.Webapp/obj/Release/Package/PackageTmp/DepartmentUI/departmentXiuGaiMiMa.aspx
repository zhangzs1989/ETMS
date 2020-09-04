<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="departmentXiuGaiMiMa.aspx.cs" Inherits="zzs.sddj.Webapp.DepartmentUI.departmentXiuGaiMiMa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改密码</title>
    <script src="../js/jquery-1.4.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#<%=txtOldPass.ClientID %>").blur(function () {
                $.ajax({
                    type: "POST",
                    contentType: "application/json",
                    url: "CheckPassword.asmx/IsCorrectPass",
                    data: "{UserName:'admin',PassWord:'" + $(this).val() + "'}",      //这里为了方便用户名就只有一个，
                    dataType: "json",                                                 //数据库里也就一条数据
                    success: function (result) {
                        $("#msg").text(result.d);
                    }
                });
            });
        });
</script>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>
                旧密码：
            </td>
            <td>
                <asp:TextBox ID="txtOldPass" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                    ControlToValidate="txtOldPass">*</asp:RequiredFieldValidator><span id="msg"></span>
            </td>
        </tr>
        <tr>
            <td>
                新密码：
            </td>
            <td>
                <asp:TextBox ID="txtNewPass" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"
                    ControlToValidate="txtNewPass">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                确认新密码：
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPass" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                    ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator"
                    Display="Dynamic" ControlToValidate="txtConfirmPass">*</asp:RequiredFieldValidator><asp:CompareValidator
                        ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="txtNewPass"
                        ControlToValidate="txtConfirmPass">两次密码不一致</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnModify" runat="server" Text="修改" onclick="btnModify_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
