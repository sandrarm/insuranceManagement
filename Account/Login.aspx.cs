using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSeguros.ClasesNegocio;
using System.Data.SqlClient;
using System.Web.Security;

namespace SistemaSeguros.Account
{
    public partial class Login : Page
    {
       
        Acceso acceso = new Acceso();

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        

        protected void Autenticar(object sender, AuthenticateEventArgs e)
        {
            bool Autenticado = false;
            Autenticado = acceso.Login(Login1.UserName, Login1.Password);

            e.Authenticated = Autenticado;

            if (Autenticado)
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
            else
            {
               //mandar a pag de error 
                
                //Response.Redirect("~/Account/Login", true);
                Login1.FailureText = "Datos incorrectos";
            }
            
        }

       

       

       
    
    }
}