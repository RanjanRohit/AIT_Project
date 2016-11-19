<%--2<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gv.aspx.cs" Inherits="gv" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" DataSourceId="source" AutoGenerateColumns="false" runat="server">
            <Columns>
            <asp:BoundField DataField="SlotId" HeaderText="SlotId" />
            <asp:BoundField DataField="Vacant" HeaderText="Vacant" />
            <asp:CommandField ShowEditButton = "True" />
            </Columns>
</asp:GridView>
        <asp:SqlDataSource ID = "source" runat = "server"
ConnectionString = " <%$ ConnectionStrings:myCon %> "
SelectCommand ="Select SlotId,Vacant from slot" />
    </div>
    </form>
</body>
</html>
