using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSeguros.ClasesNegocio;
using System.Web.UI.WebControls;
using System.Security;

namespace SistemaSeguros.ClasesInterfaz.Poliza
{
    public partial class Polizas : System.Web.UI.Page
    {
        PolizaN polNeg = new PolizaN();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                SqlDataSource1.SelectCommand = polNeg.obtListPolizasT();
            

        }

        protected void BuscarPoliza(object sender, EventArgs e)
        {
            try
            {
                string pol = numero.Text.ToString();
                SqlDataSource1.SelectCommand = polNeg.obtListPolizasBusca(pol);
            }catch(Exception  exc){
                SqlDataSource1.SelectCommand = polNeg.obtListPolizasT();
            }

        }

        protected void TodasPolizas(object sender, EventArgs e)
        {
            
            SqlDataSource1.SelectCommand = polNeg.obtListPolizasT();

        }

    }
}