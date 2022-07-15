<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FridayAssinment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        
        <asp:Label runat="server">NAME</asp:Label>
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox><br />

        <asp:Label runat="server">Mobile</asp:Label>
        <asp:TextBox ID="Mobile" runat="server"></asp:TextBox><br />
        <asp:Label runat="server">Address</asp:Label>
        <asp:TextBox ID="Address" runat="server"></asp:TextBox><br />
        <asp:Label runat="server">Designation</asp:Label>
        <asp:TextBox ID="Designation" runat="server"></asp:TextBox><br />
        <asp:Label runat="server">Father's Name</asp:Label>
        <asp:TextBox ID="FatherName" runat="server"></asp:TextBox><br />
        <asp:Label runat="server">Email ID</asp:Label>
        <asp:TextBox ID="EmailID" runat="server"></asp:TextBox><br />
        <asp:Label runat="server">DOB</asp:Label>
        <asp:TextBox ID="DOB" runat="server"></asp:TextBox><br />
       

        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />


        <div>
        </div>                                                                      
    </form>
</body>
</html>
