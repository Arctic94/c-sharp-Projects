<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Prueba1.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contacto</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="contacto">
    
        <asp:Label ID="lblnombre" runat="server" Text="Nombre Completo       :" CssClass="ct"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server" CssClass="ctt"></asp:TextBox><br />

        <asp:Label ID="Labelcorreo" runat="server" type="email" Text="Correo      :" CssClass="ct"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="ctt"></asp:TextBox><br />
        
        <asp:Label ID="Labeltelefono" runat="server" Text="Teléfono     :" CssClass="ct"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="ctt"></asp:TextBox><br />

        <asp:Label ID="Labelconsulta" runat="server" Text="Consulta      :" CssClass="ct"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="ctt" TextMode="MultiLine" Rows="10"></asp:TextBox><br />
         <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"></asp:Button>


    </div>

</asp:Content>
