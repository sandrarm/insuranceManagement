using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Configuration;
using System.Web.SessionState;

namespace SistemaSeguros.ClasesNegocio
{
    public class Acceso
    {

        segurosEntities entidad = new segurosEntities();
        PERSONA persona = new PERSONA();
        
        public bool Login(string usuario, string contrasena) {

            persona = entidad.PERSONAs.Where(b => b.usuario == usuario && b.contraseña == contrasena)
                    .FirstOrDefault();
            if (persona == null){
               return false;
            }
            else
            {
                try
                {
                    
                    HttpContext.Current.Session["tipousu"] = persona.cve_tipo_usu;
                    HttpContext.Current.Session["id_persona"] = persona.id_persona; 
                    
                }catch(Exception e){}
                return true;
            }
        }
        public bool ValidaUsuarioRepetido(string nomuser, int tipouser) {

            PERSONA persona =  new PERSONA();
            persona = entidad.PERSONAs.Where(b => b.usuario == nomuser && b.cve_tipo_usu == tipouser)
                    .FirstOrDefault();
            if (persona == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}