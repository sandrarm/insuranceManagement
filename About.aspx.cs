using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaSeguros
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var a = new segurosEntities();
            a.AJUSTADORs.Add(new AJUSTADOR());

        }
    }
}