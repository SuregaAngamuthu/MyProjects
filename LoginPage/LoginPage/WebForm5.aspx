<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="LoginPage.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Displaying the users</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        #display
        {
            text-align:center;            
        }
        #DataGridRegisteredUsers{
            margin:65px auto 0 auto;
        }
        .center-content
        {
            text-align:center;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="display" class="table-bordered">
            <asp:GridView runat="server" ID="GridViewRegisteredEmployee" OnRowDeleting="DeleteEmployee" OnRowEditing="EditEmployee" OnRowUpdating="UpdateEmployee" OnRowCancelingEdit="CancelEditEmployee">
                <Columns>
                    <asp:CommandField runat="server" ShowEditButton="true" ShowDeleteButton="true"/>
                </Columns>
            </asp:GridView>             
        </div>
    </form>
</body>
</html>
