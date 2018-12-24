<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="Aplicacion.Presentacion.Estadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 style="text-align:center">Estadísticas</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table runat="server" style="width: 1000px;" align="Center" border="1">
        <asp:TableHeaderRow><asp:TableHeaderCell ColumnSpan="6" style="text-align:center"><asp:Label ID="lblheader" runat="server" Text="Arqueros acondicionados para participar en juegos olímpicos"></asp:Label></asp:TableHeaderCell></asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Rut" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Asociación"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label6" runat="server" Text="Al día"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblrut" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblnombre" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbldireccion" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblasociacion" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblfecha_nac" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblal_dia" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

   <br />
   <br />
   <br />

     <asp:Table ID="Table1" runat="server" style="width: 1000px;" align="Center" border="1">
        <asp:TableHeaderRow><asp:TableHeaderCell ColumnSpan="6" style="text-align:center"><asp:Label ID="Label7" runat="server" Text="Arqueros por Asociación"></asp:Label></asp:TableHeaderCell></asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label8" runat="server" Text="Rut" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label9" runat="server" Text="Nombre"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label10" runat="server" Text="Dirección"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label11" runat="server" Text="Asociación"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label12" runat="server" Text="Fecha nacimiento"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="Label13" runat="server" Text="Al día"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lbl_rut" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbl_nombre" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbl_direccion" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbl_asociacion" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbl_fecha_nac" runat="server" ></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbl_al_dia" runat="server" ></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="6" align="center">
                <asp:ListBox ID="listboxasociaciones" runat="server" AutoPostBack="False" align="center" 
        DataSourceID="EntityDataSource1" DataTextField="nombre_asociacion" 
        DataValueField="id"></asp:ListBox>
    
    
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
        ConnectionString="name=solucion_fetachEntities" 
        DefaultContainerName="solucion_fetachEntities" EnableFlattening="False" 
        EntitySetName="asociacions" EntityTypeFilter="asociacion" 
        Select="it.[id], it.[nombre_asociacion]">
    </asp:EntityDataSource>
    <asp:Button ID="btnlist" runat="server" text="Ver" align="center" OnClick="select_click" />
            </asp:TableCell>
            
        </asp:TableRow>

        </asp:Table>

         

    
    
</asp:Content>
