<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BindingDataInDropDown.aspx.cs" Inherits="BindingDataDropDown.BindingDataInDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="90px" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
