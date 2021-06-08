using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Security;


namespace SistemaSeguros.ClasesInterfaz.Cliente
{
    public partial class AltaCliente : System.Web.UI.Page
    {
        bool actualizar;
        int id, tipocte;
        ClienteN clienteNeg = new ClienteN();
        PolizaN polizaNeg = new PolizaN();
        PERSONA persona;
        Acceso acc;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Datos();
            if (!IsPostBack)
                cargaDatos();


        }

        public void cargaDatos()
        {

            //if (id == 0) actualizar = false; else actualizar = true;
            if (actualizar)
            {
                this.persona = clienteNeg.obtienePersona(id);
                POLIZA p= new POLIZA();
                
                
                SqlDataSource1.SelectCommand = polizaNeg.obtListPolizas(persona.id_persona);
                CargaDatosForm(this.persona);
            }
            else
            {
                persona = new PERSONA();

            }
        }

        public void Datos()
        {

            

            try
            {
                tipocte = (int)HttpContext.Current.Session["tipousu"];
                if (tipocte == 4)
                {

                    Aceptar.Visible = false;
                    GridPolizas.Visible = false;
                    Nuevo.Visible = false;
                    Nombre.Enabled = false;
                    ApePat.Enabled = false;
                    ApeMat.Enabled = false;
                    cp.Enabled = false;
                    calle.Enabled = false;
                    numero.Enabled = false;
                    colonia.Enabled = false;
                    del.Enabled = false;
                    correo.Enabled = false;
                    usuario.Enabled = false;
                    Password.Enabled = false;
                    Password2.Enabled = false;
                    etiquetaPol.Visible = false;
                    Cancelar.Visible = false;

                }
                else
                {

                }



                id = Convert.ToInt16(Request.QueryString["id_cte"]); 
            }
            catch (Exception e)
            {
                id = 0;
            }
            if (id == 0) actualizar = false; else actualizar = true;

        }
        public void CargaDatosForm(PERSONA persona)
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
           }




        protected void btnGuardar(object sender, EventArgs e)
        {
            PERSONA persona = new PERSONA();

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
            persona.cve_tipo_usu = 4;

            bool validauser = true;
            acc = new Acceso();

            if (!actualizar) //si es nuevo registro
            {
                validauser = acc.ValidaUsuarioRepetido(usuario.Text, 4);
                if (!validauser)
                { //si es repetido
                    guardado.Text = "El nombre de usuario ya existe";
                }
            } 


            if (!validauser)
            { //si es repetido
                guardado.Text = "El nombre de usuario ya existe";
            }

            else
            {
                if (clienteNeg.agregarCliente(persona, actualizar))
                    guardado.Text = "El registro fue guardado con éxito";
                else
                    guardado.Text = "El registro no fue guardado con éxito, verificar";
            }

        }


        protected void EliminaPoliza(object sender, GridViewDeleteEventArgs e)
        {

            SqlDataSource1.DeleteCommand = polizaNeg.EliminaPoliza(Convert.ToInt32(GridPolizas.Rows[e.RowIndex].Cells[0].Text.ToString()), GridPolizas.Rows[e.RowIndex].Cells[2].Text.ToString()); 
            SqlDataSource1.SelectCommand = polizaNeg.obtListPolizas(id);
        }

        protected void EditaPoliza(object sender, GridViewEditEventArgs ed)
        {
            int num_poliza = Convert.ToInt32(GridPolizas.Rows[ed.NewEditIndex].Cells[0].Text.ToString());
            string placas = GridPolizas.Rows[ed.NewEditIndex].Cells[2].Text.ToString();
            Response.Redirect("~/ClasesInterfaz/Poliza/AdminPoliza?num_poliza=" + num_poliza + "&placas="+placas+"&id_cte="+id, true);


        }
        protected void NuevaPoliza(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Poliza/AdminPoliza?id_cte=" + id, true);

        }

        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Cliente/AdminCliente", true);
        }
    }
}