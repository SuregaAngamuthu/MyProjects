<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        #login{
            text-align:center; 
        }
        #login2{
            background-color:burlywood;
            text-align:center;
            border:5px inset black;
            border-radius:10px;
            margin-left:350px;
            margin-right:350px;
            padding:20px 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login">
            <asp:Label runat="server" Text="LOGIN PAGE"></asp:Label><br /><br />
        </div>
        <div id="login2" class="form-group">
            <asp:Label runat="server"  Text="EMPLOYEE NAME"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmpName" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUser" ControlToValidate="txtEmpName" runat="server" Display="Dynamic" ForeColor="Red" ErrorMessage="Please enter your name"></asp:RequiredFieldValidator><br /><br />
            <asp:Label runat="server"  Text="PASSWORD"></asp:Label>
            <asp:TextBox runat="server" ID="txtPwd" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPwd" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ForeColor="Red" ErrorMessage="Please enter the password"></asp:RequiredFieldValidator><br /><br />
            <asp:Button ID="loginBtn2" Cssclass="btn btn-success" runat="server" Text="LOGIN" OnClick=" loginBtn2_Click" />
        </div>
    </form>
</body>
</html>
