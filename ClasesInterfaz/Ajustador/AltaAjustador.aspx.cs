using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Security;
 

namespace SistemaSeguros.ClasesInterfaz.Ajustador
{
    public partial class AltaAjustador : System.Web.UI.Page
    {
        bool actualizar;
        int id;
        AjustadorN ajustNeg = new AjustadorN();
        PERSONA persona;
        AJUSTADOR ajustador;
        Acceso acc;

        protected void Page_Load(object sender, EventArgs e)
        
        {
            try
            {
                int tipocte = (int)HttpContext.Current.Session["tipousu"];
                if (tipocte == 2)
                {
                    Cancelar.Visible = false;
                }
            }
            catch(Exception exp){}


            this.Datos();
            if(!IsPostBack)
            cargaDatos();


           }

        public void cargaDatos() {

            

            SqlDataSourceZona.SelectCommand = ajustNeg.LisatZonas();
            zona.DataValueField = "cve_zona";
            zona.DataTextField = "desc_zona";

            //if (id == 0) actualizar = false; else actualizar = true;
            if (actualizar)
            {
                this.persona = ajustNeg.obtienePersona(id);
                this.ajustador = ajustNeg.obtieneAjustador(id);
                CargaDatosForm(this.persona,this.ajustador);
            }
            else
            {
                persona = new PERSONA();
                ajustador = new AJUSTADOR();
                
            }
        }

        public void Datos() {

            try
            {
                id = Convert.ToInt16(Request.QueryString["id_aj"]);
            }
            catch (Exception e)
            {
                id = 0;
            }
            if (id == 0) actualizar = false; else actualizar = true;
            
        }
        public void CargaDatosForm(PERSONA persona, AJUSTADOR ajustador)
        {

            Nombre.Text = persona.nombre;
            ApePat.Text = persona.ape_pat;
            ApeMat.Text = persona.ape_mat;
            cp.Text = persona.cp;
            calle.Text = persona.calle;
            numero.Text = persona.numero.ToString();
            colonia.Text = persona.colonia;
            del.Text = persona.delegacion;
            correo.Text = persona.correo;
            usuario.Text = persona.usuario;
            Password.Text = persona.contraseña;
            Password.Attributes.Add("value", persona.contraseña);
            Password2.Text = persona.contraseña;
            Password2.Attributes.Add("value", persona.contraseña);
            zona.SelectedValue = ajustador.cve_zona.ToString();
            tel.Text = ajustador.telefono;
            hrent.Text = ajustador.hora_ent.ToString().Substring(0, 5);
            hrsal.Text = ajustador.hora_sal.ToString().Substring(0, 5);



        }

       


        protected void btnGuardar(object sender, EventArgs e)
        {
            PERSONA persona = new PERSONA();
            AJUSTADOR ajustador = new AJUSTADOR();
           
            //valida nombre usuario no repetido

            persona.id_persona = id;
            persona.nombre = Nombre.Text;
            persona.ape_pat = ApePat.Text;
            persona.ape_mat = ApeMat.Text;
            persona.cp = cp.Text;
            persona.calle = calle.Text;
            persona.numero = Convert.ToInt16(numero.Text);
            persona.colonia = colonia.Text;
            persona.delegacion = del.Text;
            persona.correo = correo.Text;
            persona.usuario = usuario.Text;
            persona.contraseña = Password.Text;
            persona.cve_tipo_usu = 2;
            ajustador.id_persona = id;
            ajustador.cve_zona = Convert.ToInt16(zona.SelectedValue);
            ajustador.telefono = tel.Text;
            ajustador.hora_ent = TimeSpan.Parse(hrent.Text);
            ajustador.hora_sal = TimeSpan.Parse(hrsal.Text);

            bool validauser=true;
            acc= new Acceso();
            if (!actualizar) //si es nuevo registro
            {
                validauser = acc.ValidaUsuarioRepetido(usuario.Text, 2);
                if (!validauser) { //si es repetido
                    guardado.Text = "El nombre de usuario ya existe";
                }
            }

            if (!validauser)
            { //si es repetido
                guardado.Text = "El nombre de usuario ya existe";
            }

            else
            {
                if (ajustNeg.agregarAjustador(persona, ajustador, actualizar) && validauser)
                    guardado.Text = "El registro fue guardado con éxito";
                else
                    guardado.Text = "El registro no fue guardado con éxito, verificar";

            }
            
        }

        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Ajustador/AdminAjustador", true);
        }
    }
}