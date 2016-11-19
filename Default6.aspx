<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <asp:CommandField ShowEditButton="true" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="source" runat="server"
                ConnectionString=" <%$ ConnectionStrings:myCon %> "
                SelectCommand="Select SlotId,vac from slot where vac = 1"
                UpdateCommand ="update slot set vac = @vac where SlotId = @SlotId"/>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
