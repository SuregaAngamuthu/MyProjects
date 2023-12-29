<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="LoginPage.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
        #form1
        {
            text-align:center;
            border:4px ridge black;
            margin:150px 150px;
            padding:10px 10px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="regform">
            <h3>REGISTRATION</h3>
            <asp:Label runat="server" Text="Email"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmail" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"  ControlToValidate="txtEmail" Display="Dynamic" ForeColor="red" ErrorMessage ="Please enter your email id"></asp:RequiredFieldValidator><br /><br />
            <asp:Label ID="lblUser" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtNewUser" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewUser" runat="server"  ControlToValidate="txtNewUser" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter the username"></asp:RequiredFieldValidator><br /><br />
            <asp:Label runat="server" ID="lblPwd" Text="Password"></asp:Label>
            <asp:TextBox runat="server" ID="txtNewPwd" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPwd" runat="server"  ControlToValidate="txtNewPwd" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter the passwword"></asp:RequiredFieldValidator><br /><br />
            <asp:Label runat="server" ID="lblConPwd" Text="ConfirmPassword"></asp:Label>
            <asp:TextBox runat="server" ID="txtConPwd"  TextMode="password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConPwd" runat="server"  ControlToValidate="txtConPwd" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter the passwword again"></asp:RequiredFieldValidator><br /><br />
            <asp:Button runat="server" Id="btnReg2" Text="Register" OnClick="registerButton2_Click"/>
            <asp:Label ID="pwdError" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
