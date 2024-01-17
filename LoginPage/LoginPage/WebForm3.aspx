<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="LoginPage.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        #form1
        {
            border:4px ridge black;
            margin:300px 300px;
            padding:10px 10px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="regform" class="form-group">
            <h3 style="text-align:center">REGISTRATION</h3>

            <asp:Label runat="server" Text="EMPLOYEE ID"></asp:Label>
            <asp:TextBox runat="server" ID="txtEmpId" Cssclass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"  ControlToValidate="txtEmpId" Display="Dynamic" ForeColor="red" ErrorMessage ="Please enter your id"></asp:RequiredFieldValidator><br /><br />
            
            <asp:Label ID="lblName" runat="server" Text="EMPLOYEE NAME"></asp:Label>
            <asp:TextBox ID="txtNewEmp" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewUser" runat="server"  ControlToValidate="txtNewEmp" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter your name"></asp:RequiredFieldValidator><br /><br />
            
            <asp:Label ID="Label1" runat="server" Text="SALARY"></asp:Label>
            <asp:TextBox ID="txtSal" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="txtSal" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter your salary"></asp:RequiredFieldValidator><br /><br />
   
            <asp:Label runat="server" ID="lblPwd" Text="PASSWORD"></asp:Label>
            <asp:TextBox runat="server" ID="txtNewPwd" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPwd" runat="server"  ControlToValidate="txtNewPwd" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter your passwword"></asp:RequiredFieldValidator><br /><br />
            
            <asp:Label runat="server" ID="lblConPwd" Text="CONFIRMPASSWOPRD"></asp:Label>
            <asp:TextBox runat="server" ID="txtConPwd"  TextMode="password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConPwd" runat="server"  ControlToValidate="txtConPwd" Display="Dynamic" ForeColor="red" ErrorMessage="Please enter the passwword again"></asp:RequiredFieldValidator><br /><br />
            <asp:CompareValidator runat="server" ControlToCompare="txtNewPwd" ControlToValidate="txtConPwd" Display="Dynamic" ErrorMessage="please enter the password directly" ForeColor="Red"></asp:CompareValidator>
            
            <asp:Button runat="server" style="text-align:center" Id="btnReg2" Text="Register" CssClass="btn btn-primary" OnClick="registerButton2_Click"/>

        </div>
    </form>
</body>
</html>
