<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="uerinput.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="Lname">Name</asp:Label>
            <asp:TextBox runat="server" ID="name"></asp:TextBox>
              <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" text="Submit" />  
        </div>
    </form>
</body>
</html>
