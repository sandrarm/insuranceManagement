<%@ Page Title="Polizas" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="Polizas.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Poliza.Polizas" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent" >
    <h3>Pólizas
        
        <asp:Table HorizontalAlign="Center" runat="server">
        <asp:TableRow HorizontalAlign="Center">
            <asp:TableCell HorizontalAlign="Center">
             
               <asp:Label runat="server" AssociatedControlID="numero">Núm póliza</asp:Label>
                    <asp:TextBox runat="server" ID="numero" />
                   <%-- <asp:RequiredFieldValidator runat="server" ControlToValidate="numero" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>--%>
                     <asp:RegularExpressionValidator ControlToValidate="numero" ValidationExpression="[0-9a-zA-Z][0-9a-z-_A-Z/ ]*" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

            </asp:TableCell><asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="Buscar" runat="server" Text="Buscar póliza" OnClick="BuscarPoliza"/>
                <asp:Button ID="vertodas" runat="server" Text="Ver todas" OnClick="TodasPolizas"/>
            </asp:TableCell></asp:TableRow></asp:Table></h3><p>
    <asp:GridView HorizontalAlign="Center" id="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="num_poliza" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="num_poliza" HeaderText="Número" ReadOnly="True" SortExpression="num_poliza" />
             <asp:BoundField DataField="polizaseg" HeaderText="Póliza" ReadOnly="True" SortExpression="polizaseg" />
            
            <asp:BoundField DataField="placas" HeaderText="Placas" SortExpression="placas" />
            <asp:BoundField DataField="id_persona" HeaderText="Persona" SortExpression="id_persona" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="ape_pat" HeaderText="Ap Paterno" SortExpression="ape_pat" />
            <asp:BoundField DataField="ape_mat" HeaderText="Ap Materno" SortExpression="ape_mat" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" SelectCommand=""></asp:SqlDataSource>
        
        

    </p>
    <p>&nbsp;</p><%--<asp:Table HorizontalAlign="Center" runat="server">
         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="Nuevo" runat="server" Text="Nuevo Cliente" OnClick="NuevoCliente"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>--%>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Pólizas</h1>
            </hgroup>
        </div>
    </section>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style4 {
            width: 563px;
            height: 262px;
        }
        </style>
</asp:Content>



