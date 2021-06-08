using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Security;

namespace SistemaSeguros.ClasesInterfaz.Siniestro
{
    public partial class AltaSiniestro : System.Web.UI.Page
    {
        bool actualizar;
        int id, id_pol_sel;
        SiniestroN siniestroNeg = new SiniestroN();
        SINIESTRO siniestro;
        PolizaN poliN = new PolizaN();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Datos();
            if (!IsPostBack)
            {
                cargaDatos();
                Gridpol.Visible = false;
            }


        }

        public void cargaDatos()
        {



            SqlDataSourceGravedad.SelectCommand = siniestroNeg.ListaGravedad();
            gravedad.DataValueField = "cve_grave_les";
            gravedad.DataTextField = "desc_grave_les";

            //if (id == 0) actualizar = false; else actualizar = true;
            if (actualizar)
            {
                this.siniestro = siniestroNeg.obtieneSiniestro(id);
                id_pol_sel = siniestro.num_poliza;
                CargaDatosForm(this.siniestro);
            }
            else
            {
                siniestro = new SINIESTRO();
                
            }
        }

        public void Datos()
        {
           
            try
            {
                id = Convert.ToInt16(Request.QueryString["id_sin"]);
            }
            catch (Exception e)
            {
                id = 0;
            }
            if (id == 0) actualizar = false; else actualizar = true;

        }
        public void CargaDatosForm(SINIESTRO siniestro)
        {
            edochofer.Text = siniestro.edo_chofer;
            condiclima.Text = siniestro.condi_clima;
            conditerr.Text = siniestro.condi_terreno;
            importe.Text = siniestro.importe.ToString();
            cp.Text = siniestro.cp;
            calle.Text = siniestro.calle;
            numero.Text = siniestro.numero.ToString();
            colonia.Text = siniestro.colonia;
            del.Text = siniestro.delegacion;
            numles.Text = siniestro.num_lesionado.ToString();
            tipoacc.Text = siniestro.tipo_accidente;
            gravedad.SelectedValue = siniestro.cve_grave_les.ToString();
            clienteSin.Text = siniestro.POLIZA.PERSONA.nombre + " " + siniestro.POLIZA.PERSONA.ape_pat + " " + siniestro.POLIZA.PERSONA.ape_mat;
            id_pol_sel = siniestro.num_poliza;
            video.Text = siniestro.video;
            numpol.Text = siniestro.POLIZA.polizaseg;
            linkvideo.NavigateUrl=siniestro.video;
            try
            {
                videoYT.Src = siniestro.video.Replace("watch?v=", "embed/");
            }catch(Exception exc){}
                

        }




        protected void btnGuardar(object sender, EventArgs e)
        {
            
            SINIESTRO siniestro = new SINIESTRO();

            siniestro.edo_chofer = edochofer.Text;
            siniestro.id_siniestro = id;
            siniestro.condi_clima = condiclima.Text;
            siniestro.condi_terreno = conditerr.Text;
            siniestro.importe = Convert.ToDecimal(importe.Text);
            siniestro.cp = cp.Text;
            siniestro.calle = calle.Text;
            siniestro.numero =  Convert.ToInt16(numero.Text);
            siniestro.colonia = colonia.Text;
            siniestro.delegacion = del.Text;
            siniestro.tipo_accidente = tipoacc.Text;
            siniestro.num_lesionado = Convert.ToInt16(numles.Text);
            siniestro.cve_grave_les = Convert.ToInt16(gravedad.SelectedValue);
            //siniestro.num_poliza = Convert.ToInt32(numpol.Text);
           
            siniestro.video = video.Text;

            //valida que exista poliza
           
            try{
                 siniestro.num_poliza = poliN.obtPoliza(numpol.Text).num_poliza;
                if (siniestroNeg.agregarSINIESTRO(siniestro, actualizar))
                {
                    guardado.Text = "El registro fue guardado con éxito";
                    //videoYT.Src = siniestro.video;
                }
                else
                    guardado.Text = "El registro no fue guardado con éxito, verificar";
            
           }catch(Exception excep){
                guardado.Text = "La póliza no existe, verificar.";
                Gridpol.Visible = false;
            }

        }

        protected void btnBuscarPolizas(object sender, EventArgs e)
        {
            Gridpol.Visible = true;
            guardado.Text = "";
            
        }

        protected void Gridpol_SelectedIndexChanged(object sender, EventArgs ep)
        {
            id_pol_sel = Convert.ToInt32(Gridpol.SelectedValue);
            POLIZA poli = new POLIZA();
            
            poli=poliN.obtienePoliza(id_pol_sel);
            numpol.Text =poli.polizaseg;  //= Gridpol.SelectedValue.ToString(); // .Rows[ep.RowIndex].Cells[0].Text.ToString();
            Gridpol.Visible = false;
        }

        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Siniestro/AdminSiniestro", true);
        }
        
    }
}