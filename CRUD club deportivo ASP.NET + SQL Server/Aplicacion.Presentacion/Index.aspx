<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Aplicacion.Presentacion.Index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 style="text-align:center">Agregar Arquero</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblrut" runat="server" Text="Rut arquero"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtrut" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblnombre" runat="server" Text="Nombre completo"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtnombre" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lbldireccion" runat="server" Text="Direccion"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblasociacion" runat="server" Text="Asociación"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtasociacion" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblfecha_nac" runat="server" Text="Fecha nacimiento"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Calendar ID="calfecha_nac" runat="server" ></asp:Calendar></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:Button ID="btnAddARQ" runat="server" Text="Agregar Arquero" OnClick="brnAddARQ_Click" /></asp:TableCell>
            <asp:TableCell><asp:Label ID="resultado" runat="server" Text=""></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    </div>
</asp:Content>
