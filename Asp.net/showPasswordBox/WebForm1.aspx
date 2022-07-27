<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="showPasswordBox.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 305px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="221px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td><input type="checkbox" onchange="document.getElementById('TextBox1').type=this.checked?'text':'password'" /> ShowPassword</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
