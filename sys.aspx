<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sys.aspx.cs" Inherits="sys" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome to Car Park<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter User ID:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
