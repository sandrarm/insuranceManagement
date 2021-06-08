using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Web.SessionState;


namespace SistemaSeguros.ClasesInterfaz.MasterPages
{
    public partial class Maestra : System.Web.UI.MasterPage
    
    {
        int id_persona;     
        

        protected void Page_Load(object sender, EventArgs e)
        {

            try{


                int tipousu = (int)HttpContext.Current.Session["tipousu"];
                id_persona = (int)HttpContext.Current.Session["id_persona"];
                this.generaMenu(tipousu);

            }catch(Exception ex){
               
                
            }
        }


        public void generaMenu(int tipousu) {

            switch (tipousu)
            {
                case 1: //Administrador
                    AdminAjustLink.Visible = true;
                    AdminClienteLink.Visible = true;
                    AdminSiniLink.Visible = true;
                    AdminDatosAjustLink.Visible = false;
                    AltaSini.Visible = false;
                    Altacte.Visible = false;
                    ConsOrden.Visible = false;
                    Polizas.Visible = true;
                    break;
                case 2: //Ajustador
                    AdminAjustLink.Visible = false;
                    AdminClienteLink.Visible = false;
                    AdminSiniLink.Visible = true;
                    AdminDatosAjustLink.Visible = true; 
                    AdminDatosAjustLink.HRef = "~/ClasesInterfaz/Ajustador/AltaAjustador?id_aj="+id_persona;
                    AltaSini.Visible = false;
                    Altacte.Visible = false;
                    ConsOrden.Visible = false;
                    Polizas.Visible = false;
                    break;
                case 3://Operador

                    AdminAjustLink.Visible = true; //solo consulta
                    AdminClienteLink.Visible = false;
                    AdminSiniLink.Visible = true; 
                    AdminDatosAjustLink.Visible = false;
                    AltaSini.Visible = false; 
                    Altacte.Visible = false;
                    ConsOrden.Visible = false; 
                    Polizas.Visible = true;
                    break;
                case 4://Cliente
                    AdminAjustLink.Visible = false; 
                    AdminClienteLink.Visible = false;  
                    //no puede agregar polizas
                    Altacte.Visible = true; 
                    //enviar sus datos de cte
                    Altacte.HRef = "~/ClasesInterfaz/Cliente/AltaCliente?id_cte=" + id_persona;
                    AdminSiniLink.Visible = false; 
                    AdminDatosAjustLink.Visible = false;
                    AltaSini.Visible = false;
                    ConsOrden.Visible = true;
                    ConsOrden.HRef = "~/ClasesInterfaz/Orden/AdminOrdenes?id_cte=" + id_persona;
                    Polizas.Visible = false;

                    break;
                default:

                    break;
            }
                
        }
    }
}