<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListItemProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" BackColor="Black" Font-Bold="True" Font-Italic="True" Font-Size="Larger" ForeColor="Fuchsia" SelectionMode="Multiple">
               <%-- <asp:ListItem>india</asp:ListItem>
                <asp:ListItem>pakistan</asp:ListItem>
                <asp:ListItem>RAjpura</asp:ListItem>
                <asp:ListItem>punjab</asp:ListItem>
                <asp:ListItem>America</asp:ListItem>
                <asp:ListItem>nepali</asp:ListItem>--%>
            </asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
