<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="Solucion.Presentacion.Listar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Intensidad" HeaderText="Intensidad" 
                    SortExpression="Intensidad" />
                <asp:BoundField DataField="Profundidad" HeaderText="Profundidad" 
                    SortExpression="Profundidad" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" 
                    SortExpression="Descripcion" />
                <asp:BoundField DataField="FechaEvento" HeaderText="FechaEvento" 
                    SortExpression="FechaEvento" />
                <asp:BoundField DataField="Comuna" HeaderText="Comuna" 
                    SortExpression="Comuna" />
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            </Columns>
        </asp:GridView>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="ListarSismos" TypeName="Solucion.Negocio.ColeccionSismo">
        </asp:ObjectDataSource>
    <br /><a href="inicio.aspx">Volver</a>
    </div>
    </form>
</body>
</html>
