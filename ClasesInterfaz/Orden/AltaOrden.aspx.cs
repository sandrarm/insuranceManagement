using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Security;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SistemaSeguros.ClasesInterfaz.Orden
{
    public partial class AltaOrden : System.Web.UI.Page
    {
        bool actualizar;
        int id_orden, id_sini;
        OrdenN ordenNeg = new OrdenN();
      ORDEN orden;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Datos();
            if (!IsPostBack)
                cargaDatos();


        }

        public void cargaDatos()
        {

            SqlDataSourceEdoRepara.SelectCommand = ordenNeg.ListaEdoRepara();
            edorepara.DataValueField = "cve_edo_repa";
            edorepara.DataTextField = "desc_edo_repa";

            //if (id == 0) actualizar = false; else actualizar = true;
            if (actualizar)
            {
               
                this.orden = ordenNeg.obtieneOrden(id_orden);
                CargaDatosForm(this.orden);
            }
            else
            {
               orden = new ORDEN();
              

            }
        }

        public void Datos()
        {
            try {
                id_sini = Convert.ToInt16(Request.QueryString["id_sini"]);
            }
            catch(Exception exc){}
            try
            {
                id_orden = Convert.ToInt16(Request.QueryString["id_orden"]);
                
            }
            catch (Exception e)
            {
                id_orden = 0;
            }
            if (id_orden == 0) actualizar = false; else actualizar = true;

        }
        public void CargaDatosForm(ORDEN orden)
        {

            taller.Text = orden.taller;
            fechent.Text= (orden.fec_ent).ToString();
            edorepara.SelectedValue = orden.cve_edo_repa.ToString();
            clienteSin.Text = orden.SINIESTRO.POLIZA.PERSONA.nombre + " " + orden.SINIESTRO.POLIZA.PERSONA.ape_pat + " " + orden.SINIESTRO.POLIZA.PERSONA.ape_mat+"   -    PÓLIZA: "+orden.SINIESTRO.POLIZA.polizaseg;
            
            
        }




        protected void btnGuardar(object sender, EventArgs e)
        {
            ORDEN orden = new ORDEN();

            //valida nombre usuario no repetido
            orden.id_orden = id_orden;
            orden.taller = taller.Text;
            orden.fec_ent = Convert.ToDateTime(fechent.Text).Date;
           orden.cve_edo_repa = Convert.ToInt16(edorepara.SelectedValue);
           orden.id_siniestro = id_sini;

            if (ordenNeg.agregarOrden(orden, actualizar))
                guardado.Text = "El registro fue guardado con éxito";
            else
                guardado.Text = "El registro no fue guardado con éxito, verificar";

        }


        protected void btnEnviar(object sender, EventArgs e)
        {
            ORDEN orden = new ORDEN();
            ClienteN cteNeg = new ClienteN();
            PERSONA cte = new PERSONA();
            SINIESTRO sini = new SINIESTRO();
            SiniestroN sinNeg = new SiniestroN();
            POLIZA pol = new POLIZA();
            PolizaN polN = new PolizaN();
      
            try{
                 
            sini = sinNeg.obtieneSiniestro(id_sini);
            pol = polN.obtienePoliza(sini.num_poliza);
            cte = cteNeg.obtienePersona(pol.id_persona);

            orden.taller = taller.Text;
            orden.fec_ent = Convert.ToDateTime(fechent.Text);
            orden.cve_edo_repa = Convert.ToInt16(edorepara.SelectedValue);
            orden.id_siniestro = id_sini;

            //GENERA REPORTE
        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        PdfWriter.GetInstance(pdfDoc, Response.OutputStream);              
        pdfDoc.Open();
        pdfDoc.Add(new Paragraph("ORDEN DE SEGUIMIENTO"));
        pdfDoc.Add(new Paragraph("SINIESTRO: " + sini.id_siniestro));
        pdfDoc.Add(new Paragraph("CLIENTE: "+cte.nombre +" "+cte.ape_pat+" "+cte.ape_mat));
        pdfDoc.Add(new Paragraph("PÓLIZA: "+sini.num_poliza));
        pdfDoc.Add(new Paragraph("IMPORTE: " + sini.importe));
        pdfDoc.Add(new Paragraph("TALLER: "+orden.taller));
        pdfDoc.Add(new Paragraph("FECHA DE ENTREGA: "+orden.fec_ent));
        pdfDoc.Add(new Paragraph("ESTADO REPARACIÓN: "+edorepara.SelectedItem));
        var logo = iTextSharp.text.Image.GetInstance(Server.MapPath("~/Images/auto.png"));
        logo.SetAbsolutePosition(400, 750);
        logo.ScaleAbsolute(60,60);
        pdfDoc.Add(logo);

        pdfDoc.Close();
 
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment;" +
                                       "filename=sample.pdf");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Write(pdfDoc);
        Response.End();

            
            guardado.Text = "La orden fue guardada con éxito";
        }catch(Exception excep){
           
                guardado.Text = "El registro no fue guardado con éxito, verificar";
            }


        }

        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Siniestro/AdminSiniestro", true);
        }

    }
}