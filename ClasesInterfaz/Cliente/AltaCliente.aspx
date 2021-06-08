<%@ Page Title="Cliente" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Cliente.AltaCliente" %>

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
                <asp:TableCell Width="50%">

                    <asp:Label runat="server" AssociatedControlID="Nombre">Nombre</asp:Label>
                    <asp:TextBox runat="server" ID="Nombre" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Nombre" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="Nombre" ValidationExpression="[a-zA-Zá-úÁ-Ú ]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="ApePat">Apellido Paterno</asp:Label>
                    <asp:TextBox runat="server" ID="ApePat" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ApePat" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="ApePat" ValidationExpression="[a-zA-Zá-úÁ-Ú ]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="ApeMat">Apellido Materno</asp:Label>
                    <asp:TextBox runat="server" ID="ApeMat" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ApeMat" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="ApeMat" ValidationExpression="[a-zA-Zá-úÁ-Ú ]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="cp">C.P.</asp:Label>
                    <asp:TextBox runat="server" ID="cp" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="cp" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="cp" ValidationExpression="[1-9][0-9]{1,8}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="calle">Calle</asp:Label>
                    <asp:TextBox runat="server" ID="calle" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="calle" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="calle" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="cp">Número</asp:Label>
                    <asp:TextBox runat="server" ID="numero" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="numero" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="numero" ValidationExpression="[1-9][0-9]{0,3}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="colonia">Colonia</asp:Label>
                    <asp:TextBox runat="server" ID="colonia" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="colonia" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="colonia" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="del">Delegación/Municipio</asp:Label>
                    <asp:TextBox runat="server" ID="del" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="del" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="del" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="correo">Correo </asp:Label>
                    <asp:TextBox runat="server" ID="correo" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="correo" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="correo" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="usuario">Usuario</asp:Label>
                    <asp:TextBox runat="server" ID="usuario" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="usuario" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     
                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                    <asp:TextBox runat="server" ID="Password" TextMode="Password"  />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Obligatorio." />
                        
                </asp:TableCell><asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="Password2">Conformar contraseña</asp:Label>
                    <asp:TextBox runat="server" ID="Password2" TextMode="Password" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password2" CssClass="field-validation-error" ErrorMessage="Obligatorio." />
                    
                    <asp:CompareValidator id="comparePasswords" 
                      runat="server"
                      CssClass="field-validation-error"
                      ControlToCompare="password"
                      ControlToValidate="Password2"
                      ErrorMessage="Contraseñas diferentes!"
                      Display="Dynamic" />
                </asp:TableCell></asp:TableRow><asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                    <asp:Button ID="Aceptar" runat="server" Text="Guardar" OnClick="btnGuardar" />
                    <asp:Button ID="Cancelar" runat="server" Text="Cancelar/Regresar" OnClick="btnCancelar"  CausesValidation="False" />
                    
                    <p></p>
                    <asp:Label ID="guardado" runat="server" Font-Bold="true" BackColor="Yellow"></asp:Label>
                </asp:TableCell></asp:TableHeaderRow></asp:Table></p><p><asp:Label ID="etiquetaPol" runat="server" Font-Bold="True" Font-Size="Large" Text="Pólizas del cliente"></asp:Label></p><asp:GridView ID="GridPolizas" runat="server" AutoGenerateColumns="False" CellPadding="4" 
        DataKeyNames="num_poliza" HorizontalAlign="Center" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
        AllowPaging="True" PageSize="10" AllowSorting="True"  OnRowDeleting="EliminaPoliza" OnRowEditing="EditaPoliza">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="num_poliza" HeaderText="Numero" ReadOnly="True" SortExpression="num_poliza" />
            <asp:BoundField DataField="polizaseg" HeaderText="Póliza" ReadOnly="True" SortExpression="polizaseg" />
            <asp:BoundField DataField="placas" HeaderText="Placas" SortExpression="placas" />
            <asp:BoundField DataField="marca" HeaderText="Marca" SortExpression="marca" />
            <asp:BoundField DataField="submarca" HeaderText="Submarca" SortExpression="submarca" />
            <asp:BoundField DataField="año" HeaderText="Año" SortExpression="año" />
            

          <%--  <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="True" ShowHeader="True" />--%>
            <asp:TemplateField HeaderText="Eliminar">
             <ItemTemplate>
                <asp:LinkButton ID="LinkButton1"
             
                  CommandName="Delete" runat="server" OnClientClick="return confirm('Esta seguro que desea eliminar el registro?');">
                  Eliminar</asp:LinkButton>
              </ItemTemplate>
            </asp:TemplateField> 

            <asp:CommandField ButtonType="Button" HeaderText="Ver" ShowEditButton="True" ShowHeader="True" />
            

        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" 
            ></asp:SqlDataSource>
            
    <asp:Table HorizontalAlign="Center" runat="server">

         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                    <asp:Button ID="Nuevo" runat="server" Text="Agregar Póliza" OnClick="NuevaPoliza" />
                </asp:TableCell></asp:TableRow></asp:Table></asp:Content><asp:Content ID="Content4" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Cliente</h1></hgroup></div></section></asp:Content>