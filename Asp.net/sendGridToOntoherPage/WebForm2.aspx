<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="sendGridToOntoherPage.WebForm2" %>

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
            <table class="auto-style1">
                <tr>
                    <td>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>id</td>
                    <td>
                        <asp:TextBox ID="tid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>name</td>
                    <td>
                        <asp:TextBox ID="tname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>rollno</td>
                    <td>
                        <asp:TextBox ID="trollno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
