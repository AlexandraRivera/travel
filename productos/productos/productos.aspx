<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="productos.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView AutoGenerateColumns="false" ID="gv_productos" runat="server" >
            <Columns>
                <asp:BoundField DataField="id_prod" HeaderText="ID" SortExpression="Name" />
                <asp:BoundField DataField="nombre_prod" HeaderText="nombre" SortExpression="Name" HeaderStyle-CssClass="text-center" />
                <asp:BoundField DataField="peso_prod" HeaderText="peso" SortExpression="Name" HeaderStyle-CssClass="text-center" />
                <asp:BoundField DataField="destino_prod" HeaderText="destino" SortExpression="Name" HeaderStyle-CssClass="text-center" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
