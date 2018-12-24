<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="Aplicacion.Presentacion.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 align="center">Lista de arqueros</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Table ID="Table1" runat="server" style="width: 1000px;" align="Center" border="1">
        
        <asp:TableRow>
            
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </asp:TableCell>
            
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Asociación"></asp:Label>
            </asp:TableCell>

            <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
            </asp:TableCell>
            
        </asp:TableRow>
        <asp:TableRow>
            
            <asp:TableCell>
                <asp:Label ID="lblnombre" runat="server"></asp:Label>
            </asp:TableCell>
          
            <asp:TableCell>
                <asp:Label ID="lblasociacion" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblfecha_nac" runat="server"></asp:Label>
            </asp:TableCell>
            
        </asp:TableRow>
    </asp:Table>


</asp:Content>
