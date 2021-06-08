using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Security;



namespace SistemaSeguros.ClasesInterfaz.Poliza
{
    public partial class AdminPoliza : System.Web.UI.Page
    {
        bool actualizar;
        int id_persona,num_poliza;
        string placas_auto;
        PolizaN polizaNeg = new PolizaN();
        POLIZA poliza;
        AUTO auto;
        PERSONA clientePol;
        bool verif=true;
        ClienteN cteNeg = new ClienteN();


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
                //numero.Enabled = false;
                placas.Enabled = false;
                this.poliza = polizaNeg.obtienePoliza(num_poliza);
                this.auto = polizaNeg.obtieneAuto(placas_auto);
                CargaDatosForm(this.poliza, this.auto);
            }
            else
            {
                poliza = new POLIZA();
                auto = new AUTO();

            }
        }

        public void Datos()
        {

            try
            {
                clientePol = new PERSONA();
                num_poliza = Convert.ToInt32(Request.QueryString["num_poliza"]);
                placas_auto = Request.QueryString["placas"];
                id_persona = Convert.ToInt16(Request.QueryString["id_cte"]);
                
                clientePol = cteNeg.obtienePersona(id_persona);
                cliente.Text = clientePol.nombre.ToString().ToUpper() + " " + clientePol.ape_pat.ToString().ToUpper() + " " + clientePol.ape_mat.ToString().ToUpper();
                
            }
            catch (Exception e)
            {
                num_poliza = 0;
            }
            if (num_poliza == 0) actualizar = false; else actualizar = true;

        }
        public void CargaDatosForm(POLIZA poliza, AUTO auto)
        {
           // numero.Text = poliza.num_poliza.ToString();
            polizaseg.Text = poliza.polizaseg;
            placas.Text = auto.placas;
            marca.Text = auto.marca;
            submarca.Text = auto.submarca;
            año.Text = auto.año.ToString();
         }



        protected void btnGuardar(object sender, EventArgs e)
        {
            POLIZA poliza = new POLIZA();
            AUTO auto = new AUTO();

            //valida nombre usuario no repetido
            poliza.num_poliza = num_poliza;
            poliza.polizaseg = polizaseg.Text;
            poliza.placas = placas.Text;
            poliza.id_persona = id_persona;
            auto.placas = placas.Text;
            auto.marca = marca.Text;
            auto.submarca = submarca.Text;
            auto.año = Convert.ToInt16 (año.Text);

            PolizaN p = new PolizaN();


            if (!actualizar)
            { //verifica que no exista poliza
                verif = p.verifPoliza(num_poliza);
                if (!verif)
                { //si es repetido
                    guardado.Text = "El número de póliza ya existe";
                }

            }
            else
                verif = true;

            if (!verif)
            { //si es repetido
                guardado.Text = "El número de póliza ya existe";
            }
            else
            {
                if (polizaNeg.agregarPoliza(poliza, auto, actualizar))
                {
                    guardado.Text = "El registro fue guardado con éxito";
                   // numero.Enabled = false;
                    placas.Enabled = false;
                    Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente?id_cte=" + id_persona + "", true);


                }
                else
                    guardado.Text = "El registro no fue guardado con éxito, verificar";
            }
        }


        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente?id_cte=" + id_persona + "", true);
        }
    }
}