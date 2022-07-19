<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="All.user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:GridView runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
    <Columns>
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
    </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RohitConnectionString %>" SelectCommand="SELECT * FROM [test]"></asp:SqlDataSource>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button runat="server" Text="Button" OnClick="Unnamed_Click" />
        </div>
    </form>
</body>
</html>
