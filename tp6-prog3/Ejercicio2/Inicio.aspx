<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="tp6_prog3.Ejercicio2.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: xx-large;
            width: 90px;
        }
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 40px;
        }
        .auto-style5 {
            font-size: xx-large;
            width: 40px;
        }
        .auto-style6 {
            width: 40px;
            height: 40px;
        }
        .auto-style7 {
            width: 90px;
            height: 40px;
        }
        .auto-style8 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2"><strong>Inicio</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/Ejercicio2/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:LinkButton ID="lbEliminarPD" runat="server">Eliminar Productos seleccionados</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hl" runat="server" NavigateUrl="~/Ejercicio2/MostrarProductos.aspx.cs">Mostrar Productos</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
