<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="tp6_prog3.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">
            <br />
            Grupo N° 6<br />
            <br />
            </span></strong>
            <br />
            <asp:HyperLink ID="hlEjercicio1" runat="server" NavigateUrl="~/Ejercicio1/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="hlEjercicio2" runat="server" NavigateUrl="~/Ejercicio2/Inicio.aspx">Ejercicio 2</asp:HyperLink>
        </div>
    </form>
</body>
</html>
