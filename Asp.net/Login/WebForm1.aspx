<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 706px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">Login&nbsp; Page</td>
                </tr>
                <tr>
                    <td class="auto-style2">User Name</td>
                    <td>
                        <asp:TextBox ID="USERNAME" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="USERNAME" Display="Dynamic" ErrorMessage="enter username" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="PASSWORD" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PASSWORD" Display="Dynamic" ErrorMessage="enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="LOGIN" runat="server" Height="31px" OnClick="LOGIN_Click" Text="LOGIN" Width="106px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2"><a href="Sign.aspx">Not Register Yet?SignUp</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
