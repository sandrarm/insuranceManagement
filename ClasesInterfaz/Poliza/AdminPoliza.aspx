<%@ Page Title="Polizas" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AdminPoliza.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Poliza.AdminPoliza" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
    <p>
       
        <asp:Table ID="formulario" runat="server" Width="100%">
            
            
            <asp:TableRow  >
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">

                   
                    <asp:TextBox runat="server" ID="cliente" Enabled="false" BackColor="#CCCCCC" Font-Bold="True" ReadOnly="True" Font-Size="Medium" />
                 </asp:TableCell></asp:TableRow><asp:TableRow  >
                <%--<asp:TableCell Width="50%">

                    <asp:Label runat="server" AssociatedControlID="numero">Número</asp:Label>
                    <asp:TextBox runat="server" ID="numero" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="numero" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="numero" ValidationExpression="[0-9]{1,6}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido (máx. 6 cifras)" runat="server"/>

                </asp:TableCell> --%>

                <asp:TableCell Width="50%">

                    <asp:Label runat="server" AssociatedControlID="polizaseg">Póliza</asp:Label>
                    <asp:TextBox runat="server" ID="polizaseg" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="polizaseg" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="polizaseg" ValidationExpression="[0-9a-zA-Z][0-9a-z-_A-Z/ ]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="PLACAS">Placas</asp:Label>
                    <asp:TextBox runat="server" ID="placas" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="placas" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="placas" ValidationExpression="[a-zA-Z0-9]{6,6}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido (6 caracteres ej: 567YHF)" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="marca">marca</asp:Label>
                    <asp:TextBox runat="server" ID="marca" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="marca" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     

                </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="submarca">submarca</asp:Label>
                    <asp:TextBox runat="server" ID="submarca" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="submarca" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                    

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="año">año</asp:Label>
                    <asp:TextBox runat="server" ID="año" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="año" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="año" ValidationExpression="[1,2][0-9]{3,3}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                    <asp:Button ID="Aceptar" runat="server" Text="Guardar" OnClick="btnGuardar" />
                    <asp:Button ID="Cancelar" runat="server" Text="Cancelar/Regresar" OnClick="btnCancelar"  CausesValidation="False" />
 
                    <p></p>
                    <asp:Label ID="guardado" runat="server" Font-Bold="true" BackColor="Yellow"></asp:Label>
                </asp:TableCell></asp:TableHeaderRow></asp:Table></p><p></p>
               

</asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Póliza</h1></hgroup></div></section></asp:Content>