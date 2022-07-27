<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="learning_3tire.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 104px;
        }
        .auto-style3 {
            height: 104px;
            width: 317px;
        }
        .auto-style4 {
            width: 317px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Registration Form</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">Name</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Class</td>
                    <td>
                        <asp:TextBox ID="class" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Rollno</td>
                    <td>
                        <asp:TextBox ID="rollno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
