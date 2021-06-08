<%@ Page Title="Orden" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AdminOrdenes.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Orden.AdminOrdenes" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent" >
    <h3>Órdenes de seguimiento
        
        

    </h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" PageSize="10" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="id_siniestro" HeaderText="Siniestro" SortExpression="id_siniestro" />
                <asp:BoundField DataField="num_poliza" HeaderText="Póliza" SortExpression="num_poliza" />
                <asp:BoundField DataField="placas" HeaderText="Placas" SortExpression="placas" />
                <asp:BoundField DataField="id_orden" HeaderText="Orden" SortExpression="id_orden" />
                <asp:BoundField DataField="taller" HeaderText="Taller" SortExpression="taller" />
                <asp:BoundField DataField="fec_ent" HeaderText="Fecha entrega" SortExpression="fec_ent" />
                <asp:BoundField DataField="desc_edo_repa" HeaderText="Estado reparación" SortExpression="desc_edo_repa" />
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
    <p>&nbsp;</p>
  
    <%--<asp:Table HorizontalAlign="Center" runat="server">
        
         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="NuevaOrden" runat="server" Text="Nueva orden" OnClick="NuevaOrden"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        --%>
</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Órdenes de seguimiento</h1>
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



