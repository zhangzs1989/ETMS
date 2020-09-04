<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="zzs.sddj.Webapp.AdminUI.test" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="../CSS/CSS.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" border="0" class="css" style="width: 700px; height: 40px" cellpadding="0" cellspacing="0">
            <tr>
                <td align="center" class="csstitle" colspan="3">
                    －＝发布公告＝－</td>
            </tr>
            <tr>
                <td style="width: 56px; height: 28px;">
                    标题：</td>
                <td colspan="2" style="width: 621px; height: 28px">
                    <asp:TextBox ID="txtTitle" runat="server" Width="418px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"
                        ErrorMessage="**  必填项"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 56px; vertical-align: top;">
                    内容：<br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td colspan="2" style="width: 621px">
                        <FTB:FreeTextBox ID="FreeTextBox1" runat="server" Height="300px" Width="600px" ></FTB:FreeTextBox></td>
            </tr>
         
        </table>
    
    </div>
    </form>
</body>
</html>

