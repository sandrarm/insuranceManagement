<%@ Page Title="" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SistemaSeguros.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 417px;
            height: 174px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <h3>Bienvenido!!</h3></p>
    <p>
        Este sistema te permitirá consultar tu información de pólizas y siniestros.</p>
    <p>
        Siniestros S.A. de C.V. es una compañía seria, cuyo objetivo es ofrecerte asistencia inmediata en caso de algún siniestro.</p>
    <p>
        Tenemos el mejor precio y el paquete adecuado para ti.</p>
    <p>
        Consulta nuestras promociones.</p>
    <p>


        <asp:Table HorizontalAlign="Center" runat="server">
        
         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                <img alt="seguro" class="auto-style5" longdesc="seguro" src="Images/seguro.png" />
                </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

         
</asp:Content>
