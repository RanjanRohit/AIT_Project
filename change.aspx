<%@ Page Language="C#" AutoEventWireup="true" CodeFile="change.aspx.cs" Inherits="change" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><b>Insert more users:</b></h1>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="New UserId:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="New Password:"></asp:Label>
            &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" DataSourceID="source" AutoGenerateColumns="false" PageSize="5" AllowPaging="true" DataKeyNames="UserId" runat="server">
                <Columns>
                    <asp:BoundField DataField="UserId" HeaderText="UserId">
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:BoundField>
                    <asp:BoundField DataField="UserPw" HeaderText="UserPw">
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CardNo" HeaderText="CardNo">
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="true" />
                    <asp:CommandField ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="source" runat="server"
                ConnectionString=" <%$ ConnectionStrings:myCon %> "
                SelectCommand="Select UserId,UserPw,CardNo from LoginTable"
                UpdateCommand ="update LoginTable set CardNo = @CardNo where UserId = @UserId"
                DeleteCommand =" delete from LoginTable where UserId = @UserId" />
            <br />
            <br />
            <br />
            <h1><b>Update users:</b></h1>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Old UserId:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />

            <br />
            <asp:Label ID="Label4" runat="server" Text="New UserId:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="New Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
        <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Proceed" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
