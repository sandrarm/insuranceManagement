<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaSeguros._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                
                <h1>Control de siniestros A.C.</h1>
            </hgroup>
            <p>
                Para conocer más sobre nuestros servicios, contacta a tu agente de seguros.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Te recomendamos lo siguiente:</h3>
    <ol class="round">
        <li class="one">
            <h5>Contacta a un agente de seguros y contrata el tuyo</h5>
            Al número 33440938 o envía un e-mail a agente_seguros@sin.ca.mx</li>
        <li class="two">
            <h5>Solicita tu acceso</h5>
            A atención a clientes (01 800 9876)</li>
        <li class="three">
            <h5>Accede y consulta tu información</h5>
            Ingresa tu nombre de usuario y contraseña
        </li>
    </ol>
</asp:Content>
