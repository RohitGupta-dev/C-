<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reapeated.aspx.cs" Inherits="Repeater_Control.reapeated" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <table  border="1">
                                    <tr>
                                         <td><h3>ID</h3></td>
                                         <td><h3>name</h3></td>
                                         <td><h3>Gender</h3></td>
                                                                                    <td><h3>Rollno</h3></td>


                                    </tr>
                                    <tr>
                                       
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("id") %>'></asp:Label></td>
                                     
                                    
                                       
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("name") %>'></asp:Label></td>
                                     
                                  
                                       
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("gender") %>'></asp:Label></td>
                                     
                                    
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text='<%#Eval("rollno") %>'></asp:Label></td>
                                     
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                <br />
                                <br />
                            </SeparatorTemplate>
                        </asp:Repeater>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
