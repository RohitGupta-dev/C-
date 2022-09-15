<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ui.aspx.cs" Inherits="WebApplication1.ui" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 130px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            width: 130px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.1.js" integrity="sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=" crossorigin="anonymous"></script>
    <script>
      
      
        $(document).ready(() =>{
           
        })
        function validate() {
            var msg = "";
            var name = $("#<%=name.ClientID%>").val()
            var email = $("#<%=email.ClientID%>").val();
            var age = $("#<%=age.ClientID%>").val();
            var pwd = $("#<%=pwd.ClientID%>").val();
            var cpwd = $("#<%=cpwd.ClientID%>").val();
         if (name == "") {
             msg += "Enter name";
         }
         if (email == "") {
             msg += "Enter  email";
         }
         if (age == "") {
             msg += "Enter age ";
            }
            if (age < 18 || age > 60) {
                msg += "Age must be graeter then 18 or less then 60 ";
            }
         if (pwd == "") {
             msg += "Enter pwd ";
         }
         if (cpwd == "") {
             msg += "Enter cpwd";
         }




         if (msg != "") {
             $("#validate").append(msg);
         }
     }
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">Name</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" Display="Dynamic" ErrorMessage="enter name" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email </td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="enter Email" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Age </td>
                    <td>
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="age" Display="Dynamic" ErrorMessage="enter Age" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="pwd" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="pwd" Display="Dynamic" ErrorMessage="enter password" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CPassword </td>
                    <td>
                        <asp:TextBox ID="cpwd" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cpwd" Display="Dynamic" ErrorMessage="enter Confirm Pasword" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwd" ControlToValidate="cpwd" ErrorMessage="password must same" ForeColor="Red">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="submit" runat="server" Text="Submit" onClientClick="return validate()" OnClick="submit_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                        <div id="validate"></div>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
