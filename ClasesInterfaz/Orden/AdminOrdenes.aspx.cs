using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;

namespace SistemaSeguros.ClasesInterfaz.Orden
{
    public partial class AdminOrdenes : System.Web.UI.Page
    {

        OrdenN ordenNeg = new OrdenN();
        int id_persona = 0;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            id_persona = Convert.ToInt16(Request.QueryString["id_cte"]); 
            SqlDataSource1.SelectCommand = ordenNeg.obtListOrdenes(id_persona);


        }


      /*  protected void EliminaCliente(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt16(GridView1.Rows[e.RowIndex].Cells[0].Text.ToString());
            //valida si hay polizas asociadas al cte
            if (acc.ValidaPolizasCte(id))
            {
                SqlDataSource1.DeleteCommand = clienteNeg.EliminaCliente(id);
            }
            else
            {
                SqlDataSource1.DeleteCommand = clienteNeg.obtListClientes();
                eliminado.Text = "No se puede eliminar, tiene pólizas asociadas. Elimine las pólizas antes.";
            }


        }

        protected void EditaCliente(object sender, GridViewEditEventArgs ed)
        {
            id_persona = Convert.ToInt16(GridClientes.Rows[ed.NewEditIndex].Cells[0].Text.ToString());
            Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente?id_cte=" + id_persona + "", true);


        }

        protected void NuevoCliente(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente", true);

        }

        */

    }

}
