<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AutoIncreemnt_ID.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">id</asp:Label>
            <asp:TextBox runat="server" ID="id" readonly="true"></asp:TextBox><br /><br />
            <asp:Label runat="server">name</asp:Label>
            <asp:TextBox runat="server" ID="name"></asp:TextBox><br /><br />
            <asp:Label runat="server">rollno</asp:Label>
             <asp:TextBox runat="server" ID="rollno"></asp:TextBox><br /><br />
            <asp:Button  Text="Insert" ID="Insert" OnClick="InsertClick" runat="server"/>
            <asp:Button  Text="update" ID="update" runat="server" OnClick="update_Click"/>
            <asp:Button  Text="Delete" ID="Delete" runat="server" OnClick="Delete_Click"/>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="id">
                        <ItemTemplate>
                          
                            <asp:Label ID="labelID" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="name">
                         <ItemTemplate>
                            <asp:Label runat="server" ID="labelname" Text='<%# Eval("name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="rollno">
                         <ItemTemplate>
                            <asp:Label runat="server" ID="labelrollno" Text='<%# Eval("rollno") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField HeaderText="select" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
