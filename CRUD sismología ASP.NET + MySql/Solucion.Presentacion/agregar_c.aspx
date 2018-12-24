<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregar_c.aspx.cs" Inherits="Solucion.Presentacion.agregar_c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
    <asp:label runat="server" Text="Nombre " ID="lblprof"></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Textprofundidad"  ></asp:TextBox>
    </div>
    <asp:Button runat="server" ID="btneliminar" Text="Agregar comuna" OnClick="btnagregarc_onclick" />
    </div>
    
    </form>
</body>
</html>
