<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Prueba1.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Productos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="productos">


    <asp:Image ID="imgage" CssClass="prd" runat="server" ImageUrl="~/Images/jeans.png" ImageAlign="Middle" />
     <asp:Label ID="lblj" CssClass="prdl" runat="server" Text="Jeans Patito $8.990"></asp:Label><br />
    <asp:Image ID="Image1" CssClass="prd" runat="server" ImageUrl="~/Images/poleron.png" ImageAlign="Middle" />
    <asp:Label ID="lblp" CssClass="prdl" runat="server" Text="Poleron Addedo $12.890"></asp:Label><br />
    <asp:Image ID="Image2" CssClass="prd"  runat="server" ImageUrl="~/Images/zapatilla.png" ImageAlign="Middle" />
     <asp:Label ID="lblz" CssClass="prdl" runat="server" Text="Zapatillas Deportivas Nyke $29.990"></asp:Label><br />
    <asp:Image ID="Image3" CssClass="prd" runat="server" ImageUrl="~/Images/chaqueta.png" ImageAlign="Middle" />
    <asp:Label ID="lblc" CssClass="prdl" runat="server" Text="Chaqueta Deportiva Addedo $24.990"></asp:Label>

</div>

</asp:Content>
