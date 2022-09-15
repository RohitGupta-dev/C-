<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WebDemo.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="JavaScript/jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.css" />

    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js"></script>

    <script>
        $(document).ready(() => {
            CheckEmail()

        })
        function CheckEmail() {



            $.ajax({
                type: "Post",
                url: "ApiService.asmx/AdminData",
                contentType: 'application/json;charset=utf-8',
                datatype: 'json',
                error: function (ERR) {
                    console.log(ERR);
                },
                complete: function (jqXHR, status) {
                    
                    console.log(status);
                    

                }, success: function (res) {
                    //console.log(res)
                    //console.log(typeof (res))
                    //console.log(res.d);
                    var p = JSON.parse(res.d);
                    //console.log(typeof (p))
                    var l = p.Table.length;
                    //console.log(p.Table.length)
                   // console.log(l);
                    //var l = Object.keys(p).length;
                        var td = "<tr>";
                    for (var i = 0; i < l; i++) {
                        console.log(p.Table[i]);
                        console.log(td);
                        
                        td += "<td>" + p.Table[i].id + "</td>";
                        td += "<td>" + p.Table[i].Name + "          </td>";
                        td += "<td>" + p.Table[i].Email + "         </td>";
                        td += "<td>" + p.Table[i].Age + "           </td>";
                        td += "<td>" + p.Table[i].Address + "           </td>";
                        td += "<td>" + p.Table[i].City + "          </td>";
                        td += "<td>" + p.Table[i].Dob + "           </td>";
                        td += "<td>" + p.Table[i].Password + "          </td>";
                        td += "<td>" + p.Table[i].Photo + "         </td>";
                        td += "<td>" + p.Table[i].Profile + "           </td>";
                        td += "<td>" + p.Table[i].Qualification + "         </td>";
                        td += "<td>" + p.Table[i].State + "         </td>";
                        td += "<td><button type='button' onclick='alert()' id=" + p.Table[i].id +"_update>Update</button></td>";
                        td += "<td><button type='button' onclick='alert()' id=" + p.Table[i].id +"_Delete>Delete</button></td>";


                        td += "</tr>";
                       // td += "<td>" + p.Table[i].status + "</td></tr>";

                    }
                    console.log(td);
                    $("#GridView12").append(td);
                    //console.log(p.table);
                    console.log(p.Table[0]);
                    //console.log(p["Table"])





                    //const data = JSON.stringify(res);
                    //console.log(data.d);
                    //const json = JSON.parse(data);

                    //const tabledata = JSON.parse(json.responseJSON);
                    //console.log(tabledata);
                    //const tabledata = JSON.parse(json.responseJSON.d);
                    // const message = tabledata.Table[0].name;
                    //console.log(message);

                }
            });
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Admin </h1>
            <table id="GridView1" class="display" cellpadding="10px" border="1">
                <thead>
                    <tr>
                       <th>id</th>
<th>Name</th>
<th>Email</th>
<th>Age</th>
<th>Address</th>
<th>City</th>
<th>Dob</th>
<th>Password</th>
<th>Photo</th>
<th>Profile</th>
<th>Qualification</th>
<th>State</th>
<th>Upadte</th>
<th>Delete</th>
<%--<th>status</th>--%>
                    </tr>
                </thead>
                <tbody id="GridView12">
                   
                </tbody>
            </table>
        </div>
        <%--     <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
                <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                <asp:BoundField DataField="Qualification" HeaderText="Qualification" SortExpression="Qualification" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="Photo" HeaderText="Photo" SortExpression="Photo" />
                <asp:BoundField DataField="Profile" HeaderText="Profile" SortExpression="Profile" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBconnect %>" DeleteCommand="DELETE FROM [Tbl_Main] WHERE [id] = @id" InsertCommand="INSERT INTO [Tbl_Main] ([Name], [Email], [Password], [Dob], [Age], [Qualification], [State], [City], [Address], [Photo], [Profile], [status]) VALUES (@Name, @Email, @Password, @Dob, @Age, @Qualification, @State, @City, @Address, @Photo, @Profile, @status)" SelectCommand="SELECT * FROM [Tbl_Main]" UpdateCommand="UPDATE [Tbl_Main] SET [Name] = @Name, [Email] = @Email, [Password] = @Password, [Dob] = @Dob, [Age] = @Age, [Qualification] = @Qualification, [State] = @State, [City] = @City, [Address] = @Address, [Photo] = @Photo, [Profile] = @Profile, [status] = @status WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Dob" Type="String" />
                <asp:Parameter Name="Age" Type="Int32" />
                <asp:Parameter Name="Qualification" Type="String" />
                <asp:Parameter Name="State" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Photo" Type="String" />
                <asp:Parameter Name="Profile" Type="String" />
                <asp:Parameter Name="status" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Dob" Type="String" />
                <asp:Parameter Name="Age" Type="Int32" />
                <asp:Parameter Name="Qualification" Type="String" />
                <asp:Parameter Name="State" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Photo" Type="String" />
                <asp:Parameter Name="Profile" Type="String" />
                <asp:Parameter Name="status" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>--%>
    </form>
</body>
</html>
