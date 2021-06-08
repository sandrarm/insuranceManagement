<%@ Page Title="Orden" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaOrden.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Orden.AltaOrden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
    <p>
        <br />
        <asp:Table ID="formulario" runat="server" Width="100%">

            <asp:TableRow  >
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center" Width="50%">

                   <asp:TextBox runat="server" ID="clienteSin" Width="50%" Enabled="false" BackColor="#CCCCCC" Font-Bold="True" ReadOnly="True" Font-Size="Medium" />
                 </asp:TableCell></asp:TableRow><asp:TableRow  >
                <asp:TableCell Width="50%">

                    <asp:Label runat="server" AssociatedControlID="taller">Taller</asp:Label>
                    <asp:TextBox runat="server" ID="taller" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="taller" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="fechent" >Fecha Entrega</asp:Label>
                    <asp:TextBox runat="server" ID="fechent" TextMode="Date" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="fechent" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                    
                </asp:TableCell></asp:TableRow><asp:TableRow>
               
               <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="edorepara">Estado reparación </asp:Label>
                    <asp:DropDownList ID="edorepara" runat="server" DataSourceID="SqlDataSourceEdoRepara"
                        
                        ></asp:DropDownList>

                </asp:TableCell></asp:TableRow><asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                    <asp:Button ID="Aceptar" runat="server" Text="Guardar" OnClick="btnGuardar" />
                    
                    <asp:Button ID="Reporte" runat="server" Text="Generar PDF y enviar" OnClick="btnEnviar " />
                    <asp:Button ID="Cancelar" runat="server" Text="Cancelar/Regresar" OnClick="btnCancelar"  CausesValidation="False" />

                    <p></p>
                    <asp:Label ID="guardado" runat="server" Font-Bold="true" BackColor="Yellow"></asp:Label>
                </asp:TableCell></asp:TableHeaderRow></asp:Table></p><p></p>
               
            <asp:SqlDataSource ID="SqlDataSourceEdoRepara" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" 
            ></asp:SqlDataSource>
        
</asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Orden de seguimiento</h1>
            </hgroup>
        </div>
    </section>

</asp:Content>