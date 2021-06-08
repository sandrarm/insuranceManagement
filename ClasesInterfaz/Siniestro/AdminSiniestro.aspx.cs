using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Web.UI.WebControls;
using System.Security;

namespace SistemaSeguros.ClasesInterfaz.Siniestro
{
    public partial class AdminSiniestro : System.Web.UI.Page
    {
        SiniestroN siniestroNeg = new SiniestroN();
        int id_siniestro = 0;

        protected void Page_Load(object sender, EventArgs e)
        
        {
            try
            {
                int tipo_usr = (int)HttpContext.Current.Session["tipousu"];
                if (tipo_usr == 3)
                {
                    //Nuevo.Visible = false;
                    GridSiniestros.Columns[8].Visible = false;
                    GridSiniestros.Columns[10].Visible = false;
                }
            }
            catch (Exception excep) { }

            SqlDataSource1.SelectCommand = siniestroNeg.obtListSiniestros();
            

        }


        protected void EliminaSiniestro(object sender, GridViewDeleteEventArgs e)
        {

            SqlDataSource1.DeleteCommand = siniestroNeg.EliminaSiniestro(Convert.ToInt16(GridSiniestros.Rows[e.RowIndex].Cells[0].Text.ToString()));

        }

        protected void EditaSiniestro(object sender, GridViewEditEventArgs ed)
        {
            id_siniestro = Convert.ToInt16(GridSiniestros.Rows[ed.NewEditIndex].Cells[0].Text.ToString());
            Response.Redirect("~/ClasesInterfaz/Siniestro/AltaSiniestro?id_sin=" + id_siniestro + "", true);


        }

        protected void NuevoSiniestro(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Siniestro/AltaSiniestro", true);
            
        }

        protected void SeleccOrden(object sender, EventArgs e)
        {
            int id_orden = 0;
            int id_sini = Convert.ToInt16 (GridSiniestros.SelectedValue);
            try
            {
                id_orden = Convert.ToInt16(GridSiniestros.SelectedRow.Cells[7].Text.ToString());
            }
            catch (Exception exc) { id_orden = 0; }

            Response.Redirect("~/ClasesInterfaz/Orden/AltaOrden?id_sini="+id_sini+"&id_orden="+id_orden, true);

        }



    }
}