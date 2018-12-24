<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eliminar_c.aspx.cs" Inherits="Solucion.Presentacion.eliminar_c" %>

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
    <asp:Label runat="server" ID="lbleliminar" Text="Ingrese ID a eliminar"></asp:Label>
    </div>
    <div>
        <asp:TextBox runat="server" ID="txteliminar"></asp:TextBox>
    </div>
    <div>
        <asp:Button runat="server" ID="btneliminar" Text="Eliminar comuna" OnClick="btn_eliminarcomuna_onclick" />
    </div>

    </div>
    </form>
</body>
</html>
