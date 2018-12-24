<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Solucion.Presentacion.Inicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>SISMOTRÓN 3000</h1>
        <a href="agregar.aspx">Agregar sismos</a><br /><br />
        <a href="agregar_c.aspx">Agregar comunas</a><br /><br /><br />
        <a href="eliminar.aspx">Eliminar sismos</a><br /><br />
        <a href="eliminar_c.aspx">Eliminar comunas</a><br /><br /><br />
        <a href="listar.aspx">Listar sismos</a><br />
        <a href="listar_c.aspx">Listar comunas</a><br /><br /><br />
        <a href="modificar.aspx">Modificar sismos</a><br />
        <a href="modificar_c.aspx">Modificar comunas</a><br />
    </div>
    </form>
</body>
</html>
