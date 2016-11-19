<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usesys.aspx.cs" Inherits="usesys" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <b> Car Park Entry</b><br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Enter User ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView1" DataSourceID="source" AutoGenerateColumns="false" PageSize="5" AllowPaging="true" DataKeyNames="SlotId" runat="server">
                <Columns>
                    <asp:BoundField DataField="SlotId" HeaderText="SlotId">
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:BoundField>
                    <asp:BoundField DataField="vac" HeaderText="Vacant Slots">
                        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="source" runat="server"
                ConnectionString=" <%$ ConnectionStrings:myCon %> "
                SelectCommand="Select SlotId,vac from slot where vac = 1"/>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
    
    </div>
    </form>
</body>
</html>
