<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LoginPage.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <style>
        #form1{
            text-align:center;

        }
        #btnReg
	{
            background-color:dodgerblue;
            box-shadow:rgb(128 128 128)2px 2px  ;
            box-sizing:border-box;   
        }
        #btnLog
	{
            background-color:mediumseagreen;
            box-shadow:rgb(128 128 128)2px 2px  ; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="WELCOME !!!"></asp:Label><br /><br />
        <asp:Button ID="btnReg" runat="server" Text="REGISTER" OnClick="registerButton_Click"/>
        <asp:Button ID="btnLog" runat="server" Text="LOGIN" OnClick="loginBtn1_Click" />
    </form>
</body>
</html>