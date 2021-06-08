<%@ Page Title="Siniestro" Language="C#" MasterPageFile="~/ClasesInterfaz/MasterPages/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaSiniestro.aspx.cs" Inherits="SistemaSeguros.ClasesInterfaz.Siniestro.AltaSiniestro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
    <p>
       
        <asp:Table ID="formulario" runat="server" Width="100%">
       
            <asp:TableRow  >
                <asp:TableCell ColumnSpan="3" HorizontalAlign="Center" Width="50%">

                   <asp:TextBox runat="server" ID="clienteSin" Width="50%" Enabled="false" BackColor="#CCCCCC" Font-Bold="True" ReadOnly="True" Font-Size="Medium" />
                 </asp:TableCell></asp:TableRow><asp:TableRow  >
                <asp:TableCell Width="33%">

                    <asp:Label runat="server" AssociatedControlID="edochofer">Edo. chofer</asp:Label>
                    <asp:TextBox runat="server" ID="edochofer" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="edochofer" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="edochofer" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,250}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="condiclima">Condiciones clima</asp:Label>
                    <asp:TextBox runat="server" ID="condiclima" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="condiclima" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                    <asp:RegularExpressionValidator ControlToValidate="condiclima" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,250}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>
                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="conditerr">Condiciones terreno</asp:Label>
                    <asp:TextBox runat="server" ID="conditerr" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="conditerr" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                    <asp:RegularExpressionValidator ControlToValidate="conditerr" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,250}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="importe">Importe</asp:Label>
                    <asp:TextBox runat="server" ID="importe" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="importe" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="importe" ValidationExpression="[0-9]{1,6}([\.][0-9]{1,2}){0,1}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="video">Video (link de Youtube)</asp:Label>
                    <asp:TextBox ID="video" runat="server" />
                   
                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="cp">C.P.</asp:Label>
                    <asp:TextBox runat="server" ID="cp" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="cp" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="cp" ValidationExpression="[1-9][0-9]{1,8}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="calle">Calle</asp:Label>
                    <asp:TextBox runat="server" ID="calle" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="calle" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="calle" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                   <asp:Label runat="server" AssociatedControlID="cp">Número</asp:Label>
                    <asp:TextBox runat="server" ID="numero" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="numero" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="numero" ValidationExpression="[1-9][0-9]{0,3}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="colonia">Colonia</asp:Label>
                    <asp:TextBox runat="server" ID="colonia" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="colonia" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                   <asp:RegularExpressionValidator ControlToValidate="colonia" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="del">Delegación/Municipio</asp:Label>
                    <asp:TextBox runat="server" ID="del" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="del" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="del" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,45}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="tipoacc">Tipo de accidente (describa)</asp:Label>
                    <asp:TextBox runat="server" ID="tipoacc" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tipoacc" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                    <asp:RegularExpressionValidator ControlToValidate="tipoacc" ValidationExpression="[a-zA-Zá-úÁ-Ú -_/0-9]{1,250}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>

                </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="numles">Núm. lesionados</asp:Label>
                    <asp:TextBox runat="server" ID="numles" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="numles" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="numles" ValidationExpression="[0-9]{1,4}" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Label runat="server" AssociatedControlID="gravedad">Gravedad lesiones </asp:Label>
                    <asp:DropDownList ID="gravedad" runat="server" DataSourceID="SqlDataSourceGravedad"
                        
                        ></asp:DropDownList>
                   </asp:TableCell><asp:TableCell Width="33%">
                    <asp:Label runat="server" AssociatedControlID="numpol">Núm. poliza</asp:Label>
                    <asp:TextBox runat="server" ID="numpol" Width="70%"/>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="numpol" CssClass="field-validation-error" ErrorMessage=" *Obligatorio."  Display="Dynamic"/>
                     <asp:RegularExpressionValidator ControlToValidate="numpol" ValidationExpression="[0-9a-zA-Z][0-9a-z-_A-Z/ ]*" CssClass="field-validation-error"
                   Display="Dynamic" ErrorMessage=" *Formato inválido" runat="server"/> 
                    <asp:Button ID="polizas" runat="server" Text="Buscar" OnClick="btnBuscarPolizas" CausesValidation="False" />

                </asp:TableCell></asp:TableRow><asp:TableRow>
                <asp:TableCell ColumnSpan="3" HorizontalAlign="Center">
                    <asp:GridView ID="Gridpol" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="num_poliza" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="Gridpol_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="num_poliza" HeaderText="Núm" ReadOnly="True" SortExpression="num_poliza" />
                <asp:BoundField DataField="polizaseg" HeaderText="Póliza" SortExpression="polizaseg" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                <asp:BoundField DataField="ape_pat" HeaderText="A Paterno" SortExpression="ape_pat" />
                <asp:BoundField DataField="ape_mat" HeaderText="A Materno" SortExpression="ape_mat" />
                <asp:BoundField DataField="placas" HeaderText="Placas" SortExpression="placas" />
                <asp:CommandField ButtonType="Button" HeaderText="Seleccionar" ShowHeader="True" ShowSelectButton="True" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" SelectCommand="SELECT POLIZA.num_poliza, POLIZA.polizaseg, PERSONA.nombre, PERSONA.ape_pat, PERSONA.ape_mat, POLIZA.placas FROM PERSONA INNER JOIN POLIZA ON PERSONA.id_persona = POLIZA.id_persona"></asp:SqlDataSource>
    
                </asp:TableCell></asp:TableRow><asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="3" HorizontalAlign="Center">
                    <asp:Button ID="Aceptar" runat="server" Text="Guardar" OnClick="btnGuardar" />
                    <asp:Button ID="Cancelar" runat="server" Text="Cancelar/Regresar" OnClick="btnCancelar"  CausesValidation="False" />
                    <p></p>
                    <asp:Label ID="guardado" runat="server" Font-Bold="true" BackColor="Yellow"></asp:Label>
                </asp:TableCell></asp:TableHeaderRow></asp:Table></p><p></p>
    
    
               
            <asp:SqlDataSource ID="SqlDataSourceGravedad" runat="server" ConnectionString="<%$ ConnectionStrings:segurosConnectionString %>" 
            ></asp:SqlDataSource>
        
 
    <iframe width="560"  id="videoYT" runat="server"  height="315"
                src="" 
                ></iframe>
     <br />
    <asp:HyperLink ID="linkvideo" runat="server">Ver video en YouTube</asp:HyperLink>

</asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="FeaturedContent">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Siniestro</h1></hgroup></div></section></asp:Content>