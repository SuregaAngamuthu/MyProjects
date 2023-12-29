<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LoginPage.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
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
        <div id="login2">
            <asp:Label runat="server"  Text="USERNAME"></asp:Label>
            <asp:TextBox runat="server" ID="txtUser"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUser" ControlToValidate="txtUser" runat="server" ForeColor="Red" ErrorMessage="Please enter the username"></asp:RequiredFieldValidator><br /><br />
            <asp:Label runat="server"  Text="PASSWORD"></asp:Label>
            <asp:TextBox runat="server" ID="txtPwd" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPwd" runat="server" ControlToValidate="txtPwd" ForeColor="Red" ErrorMessage="Please enter the password"></asp:RequiredFieldValidator><br /><br />
            <asp:Button ID="loginBtn2" runat="server" Text="LOGIN" OnClick=" loginBtn2_Click" />
        </div>
    </form>
</body>
</html>
