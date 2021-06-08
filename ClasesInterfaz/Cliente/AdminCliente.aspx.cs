using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
 
namespace SistemaSeguros.ClasesInterfaz.Cliente
{
    public partial class AdminCliente : System.Web.UI.Page
    {
        
        ClienteN clienteNeg = new ClienteN();
        int id_persona=0;
        PolizaN acc = new PolizaN();
         protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = clienteNeg.obtListClientes();

            
        }

       
        protected void EliminaCliente(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt16(GridClientes.Rows[e.RowIndex].Cells[0].Text.ToString());
            //valida si hay polizas asociadas al cte
            if (acc.ValidaPolizasCte(id)) {
                SqlDataSource1.DeleteCommand = clienteNeg.EliminaCliente(id);
            }
            else {
                SqlDataSource1.DeleteCommand =clienteNeg.obtListClientes();
                eliminado.Text = "No se puede eliminar, tiene pólizas asociadas. Elimine las pólizas antes.";
            }
              
        
        }

        protected void EditaCliente(object sender, GridViewEditEventArgs ed)
        {
            id_persona=Convert.ToInt16(GridClientes.Rows[ed.NewEditIndex].Cells[0].Text.ToString());   
            Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente?id_cte="+id_persona+"", true);


        }

        protected void NuevoCliente(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Cliente/AltaCliente", true);

        }

        
       
    }

  }
