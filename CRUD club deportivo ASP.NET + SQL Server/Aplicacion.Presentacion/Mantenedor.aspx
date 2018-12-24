<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Mantenedor.aspx.cs" Inherits="Aplicacion.Presentacion.Mantenedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 align="center">Mantenedor</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lblnombreASO" runat="server" Text="Ingrese nombre Asociación"></asp:Label><br />
    <asp:TextBox ID="txtnombreASO" runat="server"></asp:TextBox><br />
    <asp:Label ID="lbldireccionASO" runat="server" Text="Ingrese direccion Asociación"></asp:Label><br />
    <asp:TextBox ID="txtdireccionASO" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnAgregarASO" runat="server" OnClick="btnAgregarASO_onclick" Text="Agregar Asociacion" /><br /><br /><br />

    <asp:Label ID="lblnombreASO_eliminar" runat="server" Text="Ingrese ID Asociación a eliminar"></asp:Label><br />
    <asp:TextBox ID="txtnombreASO_eliminar" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnASO_eliminar" runat="server" OnClick="btnEliminarASO_onclick" Text="Eliminar Asociacion" /><br /><br /><br />

    <asp:Label ID="Label3" runat="server" Text="Ingrese ID Asociación"></asp:Label><br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label1" runat="server" Text="Ingrese nombre Asociación"></asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Ingrese direccion Asociación"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" OnClick="btnmodificarASO_onclick" Text="Modificar Asociacion" />
    <asp:Button ID="Button2" runat="server" OnClick="btnmodificarASO_onclick2" Text="Guardar cambios" /><br /><br /><br />

    <asp:Table ID="Table1" runat="server" style="width: 600px;" align="left" border="1">
        
        <asp:TableRow>
            
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="nombre usuario"></asp:Label>
            </asp:TableCell>
            
            <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="nombre completo"></asp:Label>
            </asp:TableCell>

            <asp:TableCell>
                <asp:Label ID="Label6" runat="server" Text="contraseña"></asp:Label>
            </asp:TableCell>
            
        </asp:TableRow>
        <asp:TableRow>
            
            <asp:TableCell>
                <asp:Label ID="lblnombreusuario" runat="server"></asp:Label>
            </asp:TableCell>
          
            <asp:TableCell>
                <asp:Label ID="lblnombrecompleto" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblcontrasenna" runat="server"></asp:Label>
            </asp:TableCell>
            
        </asp:TableRow>
    </asp:Table>
</asp:Content>
