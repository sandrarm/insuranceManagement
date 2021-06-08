<%@ Page Title="Siniestros" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AdminSiniestro.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Siniestro.AdminSiniestro" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Siniestros
        
        <asp:GridView ID="GridSiniestros" runat="server" AutoGenerateColumns="False" CellPadding="4" 
        DataKeyNames="id_siniestro" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
        AllowPaging="True" PageSize="10" AllowSorting="True"  OnRowDeleting="EliminaSiniestro" OnRowEditing="EditaSiniestro" OnSelectedIndexChanged="SeleccOrden">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_siniestro" HeaderText="Id" ReadOnly="True" SortExpression="id_persona" />
            <asp:BoundField DataField="num_poliza" HeaderText="Núm." SortExpression="num_poliza" />
            <asp:BoundField DataField="polizaseg" HeaderText="Póliza" SortExpression="´polizaseg" />
            <asp:BoundField DataField="placas" HeaderText="placas" SortExpression="placas" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="ape_pat" HeaderText="A Paterno" SortExpression="ape_pat" />
            <asp:BoundField DataField="ape_mat" HeaderText="A Materno" SortExpression="ape_mat" />
            <asp:BoundField DataField="id_orden" HeaderText="Orden" SortExpression="id_orden" Visible="true" />


            <%--<asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="True" ShowHeader="True" />--%>
            
            <asp:TemplateField HeaderText="Eliminar">
             <ItemTemplate>
                <asp:LinkButton ID="LinkButton1"
             
                  CommandName="Delete" runat="server" OnClientClick="return confirm('Esta seguro que desea eliminar el registro?');">
                  Eliminar</asp:LinkButton>
              </ItemTemplate>
            </asp:TemplateField> 

            <asp:CommandField ButtonType="Button" HeaderText="Ver" ShowEditButton="True" ShowHeader="True" EditText=" Ver/Editar" />
            

            <asp:CommandField ButtonType="Button" HeaderText="Ver Orden" ShowHeader="True" ShowSelectButton="True" SelectText="Ver Orden" />
            

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

        <asp:Table HorizontalAlign="Center" runat="server">
        <asp:TableRow HorizontalAlign="Center">

            <asp:TableCell HorizontalAlign="Center" Width="33%">
                <asp:Label runat="server" AssociatedControlID="buscanombre">Nombre</asp:Label>
                 <asp:TextBox ID="buscanombre" runat="server"></asp:TextBox>     
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Center" Width="33%">
                 <asp:Label runat="server" AssociatedControlID="buscaPoliza">Póliza</asp:Label>
                <asp:TextBox ID="buscaPoliza" runat="server"></asp:TextBox>
            </asp:TableCell>
             <asp:TableCell HorizontalAlign="Center" Width="33%">
                 <asp:Label runat="server" AssociatedControlID="buscaPlacas">Placas</asp:Label>
                <asp:TextBox ID="buscaPlacas" runat="server"></asp:TextBox>
            </asp:TableCell>
         </asp:TableRow>
         <asp:TableRow HorizontalAlign="Center" >
                <asp:TableCell HorizontalAlign="Center" ColumnSpan="3">
                      <asp:Button ID="BtnBusca" runat="server" Text="Buscar" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" >

               <SelectParameters>
                <asp:ControlParameter ControlID="buscaNombre" DefaultValue="%" Name="nombre" PropertyName="Text"
                    Type="String" />
                <asp:ControlParameter ControlID="buscaPoliza" DefaultValue="%" Name="poliza" PropertyName="Text"
                    Type="String" />
                    <asp:ControlParameter ControlID="buscaPlacas" DefaultValue="%" Name="placas" PropertyName="Text"
                    Type="String" />
            </SelectParameters>


        </asp:SqlDataSource>
    </h3>
    <p>&nbsp;</p>
   
    <asp:Table HorizontalAlign="Center" runat="server">
       
         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="Nuevo" runat="server" Text="Nuevo Siniestro" OnClick="NuevoSiniestro" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

   
    

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Administrar Siniestros</h1>
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
