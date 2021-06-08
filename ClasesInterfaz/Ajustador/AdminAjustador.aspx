<%@ Page Title="Ajustadores" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AdminAjustador.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Ajustador.AdminAjustador" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Ajustadores
        
        <asp:GridView ID="GridAjust" runat="server" AutoGenerateColumns="False" CellPadding="4" 
        DataKeyNames="id_persona" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
        AllowPaging="True" AllowSorting="True"  OnRowDeleting="EliminaAjustador" OnRowEditing="EditaAjustador"  >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id_persona" HeaderText="Id" ReadOnly="True" SortExpression="id_persona" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
            <asp:BoundField DataField="ape_pat" HeaderText="A Paterno" SortExpression="ape_pat" />
            <asp:BoundField DataField="ape_mat" HeaderText="A Materno" SortExpression="ape_mat" />
            <asp:BoundField DataField="correo" HeaderText="Correo" SortExpression="correo" />
            <asp:BoundField DataField="telefono" HeaderText="Teléfono" SortExpression="telefono" />
            <asp:BoundField DataField="hora_ent" HeaderText="H Entrada" SortExpression="hora_ent" />
            <asp:BoundField DataField="hora_sal" HeaderText="H Salida" SortExpression="hora_sal" />
            <asp:BoundField DataField="desc_zona" HeaderText="Zona" SortExpression="desc_zona" />
            
            <%--<asp:CommandField ButtonType="Button" HeaderText ="Eliminar" ShowDeleteButton="True" ShowHeader="True" />--%>
            <asp:TemplateField HeaderText="Eliminar">
             <ItemTemplate>
                <asp:LinkButton ID="LinkButton1"
             
                  CommandName="Delete" runat="server" OnClientClick="return confirm('Esta seguro que desea eliminar el registro?');">
                  Eliminar</asp:LinkButton>
              </ItemTemplate>
            </asp:TemplateField> 


            <asp:CommandField ButtonType="Button" HeaderText="Ver/Editar" ShowEditButton="True" ShowHeader="True" EditText="Ver/Editar" />
            
            
            
            
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

            <asp:TableCell HorizontalAlign="Center">
                <asp:Label runat="server" AssociatedControlID="buscanombre">Nombre</asp:Label>
                 <asp:TextBox ID="buscanombre" runat="server"></asp:TextBox>     
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Center">
                 <asp:Label runat="server" AssociatedControlID="buscaZona">Zona</asp:Label>
                <asp:TextBox ID="buscaZona" runat="server"></asp:TextBox>
            </asp:TableCell>
            
         </asp:TableRow>
         <asp:TableRow HorizontalAlign="Center" >
                <asp:TableCell HorizontalAlign="Center" ColumnSpan="2">
                      <asp:Button ID="BtnBusca" runat="server" Text="Buscar" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>


        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" >
            <SelectParameters>
                <asp:ControlParameter ControlID="buscaNombre" DefaultValue="%" Name="nombre" PropertyName="Text"
                    Type="String" />
                <asp:ControlParameter ControlID="buscaZona" DefaultValue="%" Name="zona" PropertyName="Text"
                    Type="String" />
            </SelectParameters>

        </asp:SqlDataSource>
        

    </h3>
    <p>&nbsp;</p>
    
        <asp:Table HorizontalAlign="Center" runat="server">
       
         <asp:TableRow HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="Nuevo" runat="server" Text="Nuevo Ajustador" OnClick="NuevoAjustador" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>


    

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Administrar Ajustadores</h1>
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



