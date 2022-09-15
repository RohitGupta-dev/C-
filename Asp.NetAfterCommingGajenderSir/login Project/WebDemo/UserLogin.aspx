<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WebDemo.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="JavaScript/jquery.js"></script>
    <script>
        $(document).ready(() => {
            
        })

      <%--  function CheckEmail() {
         var   dEmail = $('#<%=TextBox1.ClientID%>');
            var e = dEmail.val();
           // e = JSON.stringify(e);
            console.log(e);
            $.ajax({
                type: "POST",
                url: "https://localhost:44334/ApiService.asmx/CheckMail",
                data: "{ 'Email': '"+e+"' } ",
                //data: "{Email :'" + dEmail.value +"'}",
                contentType: 'application/json;charset=utf-8',
                datatype: 'json',
                error: function (ERR) {
                    console.log(ERR);
             
                },
                complete: function (jqXHR, status) {
                    console.log(jqXHR);
                    console.log(status);
                    alert(status);
                }, success: function (res) {
                    //alert(data)
                    //console.log(data.d.name)
                    //var p = JSON.stringify(data);
                    //j=JSON.parse(p);
                    //console.log(JSON.parse(p));
                    //console.log(j.name)
                    //successmessage = 'Data was succesfully captured';
                    const data = JSON.stringify(res);
                    const json = JSON.parse(data);
                    const tabledata = JSON.parse(json.responseJSON.d);
                    const message = tabledata.Table[0].name;
                    console.log(message);

                }
            });
        }--%>
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 795px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">lOGIN FORM</td>
                    
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>UserName</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" onchange="CheckEmail()"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Log in" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="SignUp" runat="server" OnClick="SignUp_Click" Text="Sing up" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
