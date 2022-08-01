<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="DataTable_Jquery_Plugin.demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="js/jquery.dataTables.min.css" />
    <style>  
    .showHide {  
        cursor: pointer;  
    }  
</style>  
    <script src="js/jquery-3.6.0.js" ></script>
    <script src="js/jquery.dataTables.min.js" ></script>
    <script>
        $(document).ready(function () {
            $.ajax({
                type: "POST",
                dataType: "json",
                url: "AddPlugin.asmx/GetStudentDetaials",
                success: function (data) {
                    var datatableVariable = $('#studentTable').DataTable({
                        data: data,
                        columns: [
                            { 'data': 'iD' },
                            { 'data': 'firstName' },
                            { 'data': 'lastName' },
                            {
                                'data': 'feesPaid', 'render': function (feesPaid) {
                                    return '$ ' + feesPaid;
                                }
                            },
                            { 'data': 'gender' },
                            { 'data': 'emailId' },
                            { 'data': 'telephoneNumber' },
                            {
                                'data': 'dateOfBirth', 'render': function (date) {
                                    var date = new Date(parseInt(date.substr(6)));
                                    var month = date.getMonth() + 1;
                                    return date.getDate() + "/" + month + "/" + date.getFullYear();
                                }
                            }]
                    });
                    ////////$('#studentTable tfoot th').each(function () {
                    ////////    var placeHolderTitle = $('#studentTable thead th').eq($(this).index()).text();
                    ////////    $(this).html('<input type="text" class="form-control input input-sm" placeholder = "Search ' + placeHolderTitle + '" />');
                    ////////});
                    ////////datatableVariable.columns().every(function () {
                    ////////    var column = this;
                    ////////    $(this.footer()).find('input').on('keyup change', function () {
                    ////////        column.search(this.value).draw();
                    ////////    });
                    ////////});
                    ////////$('.showHide').on('click', function () {
                    ////////    var tableColumn = datatableVariable.column($(this).attr('data-columnindex'));
                    ////////    tableColumn.visible(!tableColumn.visible());
                    ////////});
                }
            });

        });

    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
                 <div style="padding: 10px; border: 5px solid black; margin-top: 50px" class="container-fluid">  
            <div>  
              <%--  <b class="label label-danger" style="padding: 8.5px">Click to Show or Hide Column:</b>  
                <div class="btn-group btn-group-sm">  
                    <a class="showHide btn btn-primary" data-columnindex="0">ID</a>  
                    <a class="showHide btn btn-primary" data-columnindex="1">FirstName</a>  
                    <a class="showHide btn btn-primary" data-columnindex="2">LastName</a>  
                    <a class="showHide btn btn-primary" data-columnindex="3">FeesPaid</a>  
                    <a class="showHide btn btn-primary" data-columnindex="4">Gender</a>  
                    <a class="showHide btn btn-primary" data-columnindex="5">Email</a>  
                    <a class="showHide btn btn-primary" data-columnindex="6">TelephoneNumber</a>  
                    <a class="showHide btn btn-primary" data-columnindex="7">Date of Birth</a>  
                </div>  --%>
            </div>  
            <br />  
            <table id="studentTable" class="table table-responsive table-hover">  
                <thead>  
                    <tr>  
                        <th>ID</th>  
                        <th>First Name</th>  
                        <th>Last Name</th>  
                        <th>Fees Paid</th>  
                        <th>Gender</th>  
                        <th>Email</th>  
                        <th>Telephone Number</th>  
                        <th>Date of Birth</th>  
                    </tr>  
                </thead>  
                <tfoot>  
                    <tr>  
                        <th>ID</th>  
                        <th>First Name</th>  
                        <th>Last Name</th>  
                        <th>Fees Paid</th>  
                        <th>Gender</th>  
                        <th>Email</th>  
                        <th>Telephone Number</th>  
                        <th>Date of Birth</th>  
                    </tr>  
                </tfoot>  
            </table>  
        </div>  
        </div>
    </form>
</body>
</html>
