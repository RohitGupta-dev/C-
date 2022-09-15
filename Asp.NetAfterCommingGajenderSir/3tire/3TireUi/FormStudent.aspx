<%@ Page Title="" Language="C#" MasterPageFile="~/Studentdata.Master" AutoEventWireup="true" CodeBehind="FormStudent.aspx.cs" Inherits="_3TireUi.FormStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 331px;
        }
        .auto-style5 {
            width: 331px;
            height: 61px;
        }
        .auto-style6 {
            height: 61px;
        }
        .auto-style7 {
            width: 331px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    



    <table class="auto-style1">


        <tr>
            <td class="auto-style7">

            </td> <td>

                Student Form&#39;s</td>

        </tr>
        <tr>
            <td class="auto-style5">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidateRequestMode="Disabled" ForeColor="Red" />
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style7">Student Name</td>
            <td>
                <asp:TextBox ID="studentName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="studentName" ErrorMessage="enter Name" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">ROll No</td>
            <td>
                <asp:TextBox ID="StuderntRollno" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="StuderntRollno" ForeColor="Red" ErrorMessage="Enter RollNo">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Class </td>
            <td>
                <asp:DropDownList ID="DropDownListClass" runat="server">
                    <asp:ListItem>Select One</asp:ListItem>
                    <asp:ListItem>BCA</asp:ListItem>
                    <asp:ListItem>MSC</asp:ListItem>
                    <asp:ListItem>BSC</asp:ListItem>
                    <asp:ListItem>Btech</asp:ListItem>
                    <asp:ListItem>MCA</asp:ListItem>
                </asp:DropDownList>
              
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownListClass" ErrorMessage="choose Class" ForeColor="Red">*</asp:RequiredFieldValidator>
              
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Gender </td>
            <td>
                <asp:RadioButtonList ID="StudentGender" runat="server">
                    <asp:ListItem Value="M">Male</asp:ListItem>
                    <asp:ListItem Value="F">Female</asp:ListItem>
                    <asp:ListItem Value="O">Other</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="StudentGender" ErrorMessage="enter Gender" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Student Photo </td>
            <td class="auto-style2">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FileUpload1" ErrorMessage="image Upload" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style2">
                <asp:Button ID="SaveData" runat="server" Text="Submit" OnClick="SaveData_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style2"></td>
        </tr>
    </table>
    



</asp:Content>
