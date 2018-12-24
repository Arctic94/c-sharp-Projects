<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificar.aspx.cs" Inherits="Solucion.Presentacion.modificar" %>

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
    <asp:Label runat="server" ID="lblbuscar" Text="Ingrese ID a modificar"></asp:Label>
    </div>
    <div>
        <asp:TextBox runat="server" ID="txtbuscar"></asp:TextBox>
    </div>
    <div>
        <asp:Button runat="server" ID="btnbuscar" Text="Buscar sismo" OnClick="btn_buscarsismo_onclick" />
    </div>

    <div>
    <asp:label runat="server" Text="profundidad " ID="lblprof"></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Textprofundidad" MaxLength="6" ></asp:TextBox>
    </div>
    <div>
    <asp:label ID="Labelintensidad" runat="server" Text="intensidad "></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Textintensidad" MaxLength="4" ></asp:TextBox>
    </div>
    <div>
    <asp:label ID="Labeldescrp" runat="server" Text="descripcion"></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Textdescripcion" ></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="lblcomuna" runat="server" Text="comuna"></asp:Label>
    <asp:TextBox ID="txtcomuna" runat="server" ></asp:TextBox>
    </div>
    







    <div>
    <asp:label ID="Labelfecha" runat="server" Text="fecha"></asp:label>
    </div>
    <div>
    <asp:Calendar runat="server" ID="calendario"></asp:Calendar>
    </div>
    <div>
    <asp:label ID="Labelhora" runat="server" Text="hora "></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Texthora" ></asp:TextBox>
    </div>
    <div>
    <asp:label ID="Labelminuto" runat="server" MaxLength="2" Text="minuto"></asp:label>
    </div>
    <div>
    <asp:TextBox runat="server" id="Textminuto" MaxLength="2" ></asp:TextBox>

    


    </div>
    <asp:Button runat="server" ID="guardar" text="Guardar cambios" OnClick="btnguardar_onclick" />





    </div>
    </form>
</body>
</html>
