<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificar_c.aspx.cs" Inherits="Solucion.Presentacion.modificar_c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilo.css" rel="stylesheet" type="text/css" />
    <link href="estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
    <div>
    <asp:Label runat="server" ID="lblbuscar" Text="Ingrese ID a modificar"></asp:Label>
    </div>
    <div>
        <asp:TextBox runat="server" ID="txtbuscar"></asp:TextBox>
    </div>
    <div>
        <asp:Button runat="server" ID="btnbuscar" Text="Buscar comuna" OnClick="btn_buscarcomuna_onclick" />
    </div>

    <div>
    <asp:label runat="server" Text="Nombre " ID="lblprof"></asp:label>
    <asp:TextBox runat="server" ID="txtnombre"></asp:TextBox>
    </div>





    


    </div>
    <asp:Button runat="server" ID="guardar" text="Guardar cambios" OnClick="btnguardar_onclick" />





    </div>
    </div>
    </form>
</body>
</html>
