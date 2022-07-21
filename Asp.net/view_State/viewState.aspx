<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewState.aspx.cs" Inherits="view_State.viewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">userName</td>
                    <td>
                        <asp:TextBox ID="user" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="submit" />
                        <asp:Button ID="Restore" runat="server" OnClick="Restore_Click" Text="Restore" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
