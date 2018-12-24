<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Prueba1.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="inicio">
    <asp:Image ID="img1"  runat="server" ImageUrl="~/Images/imagen1.jpg" ImageAlign="Middle" /><br />
    <asp:Label ID="contacto"  runat="server" Text="Contacto: Sr. Odnev Licaf"></asp:Label><br />
    <asp:Label ID="telefono"  runat="server" Text="Teléfono: 555555"></asp:Label>

</div>
    
</asp:Content>
