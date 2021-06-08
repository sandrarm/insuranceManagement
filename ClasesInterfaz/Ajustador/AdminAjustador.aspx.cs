using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Web.UI.WebControls;
using System.Security;

namespace SistemaSeguros.ClasesInterfaz.Ajustador
{
    public partial class AdminAjustador : System.Web.UI.Page
    {
        AjustadorN ajustNeg = new AjustadorN();
        int id_persona=0, tipo_usr;

         protected void Page_Load(object sender, EventArgs e)
        {
            try { 
             tipo_usr = (int)HttpContext.Current.Session["tipousu"];
             if (tipo_usr == 3)
             {
                 Nuevo.Visible = false;
                 GridAjust.Columns[9].Visible = false;
                 GridAjust.Columns[10].Visible = false;
             }
             }catch(Exception excep){
            }

            SqlDataSource1.SelectCommand = ajustNeg.obtListAjustadores();
            

            
        }

       
        protected void EliminaAjustador(object sender, GridViewDeleteEventArgs e)
        {

            
            SqlDataSource1.DeleteCommand = ajustNeg.EliminaAjustador(Convert.ToInt16(GridAjust.Rows[e.RowIndex].Cells[0].Text.ToString()));   


        
        }

        protected void EditaAjustador(object sender, GridViewEditEventArgs ed)
        {
            id_persona=Convert.ToInt16(GridAjust.Rows[ed.NewEditIndex].Cells[0].Text.ToString());   
            Response.Redirect("~/ClasesInterfaz/Ajustador/AltaAjustador?id_aj="+id_persona+"", true);


        }

        protected void NuevoAjustador(object sender, EventArgs e)
        {
            Response.Redirect("~/ClasesInterfaz/Ajustador/AltaAjustador", true);

        }

        
        
       
    }
}