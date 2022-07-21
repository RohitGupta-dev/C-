<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondViewForm.aspx.cs" Inherits="view_State.SecondViewForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="restore" runat="server" Text="restore" />
    </form>
</body>
</html>
