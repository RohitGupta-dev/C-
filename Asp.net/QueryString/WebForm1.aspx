<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueryString.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>id </td>
                <td>
                    <asp:TextBox ID="id" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>name</td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>class</td>
                <td>
                    <asp:TextBox ID="class" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
