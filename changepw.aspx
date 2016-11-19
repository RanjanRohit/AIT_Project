<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepw.aspx.cs" Inherits="changepw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        Hi user, &nbsp;
            
            <br />
            Enter your new password:&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Proceed To CMS" Width="106px" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
