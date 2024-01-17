<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        #form1{
            text-align:center;

        }
        #btnReg{
            box-shadow:rgb(128 128 128)2px 2px  ;
            box-sizing:border-box;   
/*            display:inline-block;
*/        }
        #btnLog{
            background-color:mediumseagreen;
            box-shadow:rgb(128 128 128)2px 2px  ; 
/*            display:inline-block;
*/        }
        *{
            background-color:lightpink;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="WELCOME" BorderColor="#CC00FF"></asp:Label><br /><br />
        <asp:Button ID="btnReg" runat="server" class="btn btn-primary" Text="REGISTER" OnClick="registerButton_Click"/>
        <asp:Button ID="btnLog" runat="server" class="btn btn-success" Text="LOGIN" OnClick="loginBtn1_Click" />
    </form>
</body>
</html>