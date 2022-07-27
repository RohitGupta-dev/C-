<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign.aspx.cs" Inherits="Login.Sign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 3px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 146px;
        }
        .auto-style4 {
            height: 23px;
            width: 146px;
        }
        .auto-style5 {
            width: 146px;
            height: 28px;
        }
        .auto-style6 {
            height: 28px;
        }
        .auto-style7 {
            width: 146px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">Sign Up Form<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">First name</td>
                    <td>
                        <asp:TextBox ID="fname" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fname" Display="Dynamic" ErrorMessage="Plz Enter first Name" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">last name</td>
                    <td>
                        <asp:TextBox ID="lname" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lname" Display="Dynamic" ErrorMessage="enter lastname" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>male</asp:ListItem>
                            <asp:ListItem>female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Email</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="email" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="enter email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="enter valid email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Address</td>
                    <td>
                        <asp:TextBox ID="address" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="address" Display="Dynamic" ErrorMessage="enter Address" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Username</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="username" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="username" Display="Dynamic" ErrorMessage="enter username" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="password" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="enter password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Conform Password</td>
                    <td>
                        <asp:TextBox ID="cpasssword" runat="server" Width="195px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cpasssword" Display="Dynamic" ErrorMessage="enter conform password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="cpasssword" ErrorMessage="password must same" ForeColor="#CC0000" SetFocusOnError="True">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="submit" Width="90px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td><a href="WebForm1.aspx">Login</a>
                        </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
