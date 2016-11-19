<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<body>
    <form id="form1" runat="server">
        
        
    <div>

        <br />
        <h2><b>Admin Login</b></h2><br />

        <asp:Label ID="Label2" runat="server" Text="Admin UserName" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="128px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter admin username in reg no"></asp:RequiredFieldValidator>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Admin Password" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="128px" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter admin password"></asp:RequiredFieldValidator>

        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/><br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br/>
        <br/>
    </div>
    </form>
</body>
</html>
