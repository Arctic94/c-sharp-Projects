<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregar.aspx.cs" Inherits="Solucion.Presentacion.agregar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div>    
    <asp:label runat="server" Text="ID comuna " ID="Labelcomuna"></asp:label>
    </div>
    <div>
        <asp:DropDownList ID="DropDownList2" runat="server" 
            DataSourceID="ObjectDataSource1" DataTextField="Nombre" DataValueField="ID">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="ListarComunas" TypeName="Solucion.Negocio.ColeccionComuna">
        </asp:ObjectDataSource>
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
    <asp:Button runat="server" ID="enviar" text="Ingresar sismo" OnClick="btnenviar_onclick" />


    
    </form>
</body>
</html>
