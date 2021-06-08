using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Configuration;
using System.Web.SessionState;
using SistemaSeguros.ClasesNegocio;
using System.Web.UI.WebControls;

namespace SistemaSeguros.ClasesNegocio
{
    public class ClienteN
    {
        segurosEntities entidad = new segurosEntities();
        PERSONA persona = new PERSONA();


        public string obtListClientes()
        {

            string query = "SELECT PERSONA.id_persona, PERSONA.nombre, PERSONA.ape_pat, PERSONA.ape_mat, PERSONA.correo, PERSONA.usuario FROM PERSONA WHERE cve_tipo_usu = 4 AND ((PERSONA.nombre LIKE '%' + @nombre + '%') OR (PERSONA.ape_pat LIKE '%' + @nombre + '%') OR (PERSONA.ape_mat LIKE '%' + @nombre + '%'))";
            return query;
        }

        public string EliminaCliente(int id_persona)
        {
            //ELIMINAR POLIZAS Y AUTOS
            string sqlBorrar = "DELETE FROM PERSONA WHERE id_persona = " + id_persona + ";";
            return sqlBorrar;

        }
        
        public PERSONA obtienePersona(int id_per)
        {

            PERSONA aj = entidad.PERSONAs.Find(id_per);
            return aj;
        }

        public bool agregarCliente(PERSONA persona, bool actualiza)
        {

            PERSONA personaAct;
           
             try
            {
            if (actualiza)
            {
                personaAct = entidad.PERSONAs.First(p => p.id_persona == persona.id_persona);
                personaAct.nombre = persona.nombre;
                personaAct.ape_pat = persona.ape_pat;
                personaAct.ape_mat = persona.ape_mat;
                personaAct.cp = persona.cp;
                personaAct.calle = persona.calle;
                personaAct.numero = persona.numero;
                personaAct.colonia = persona.colonia;
                personaAct.delegacion = persona.delegacion;
                personaAct.correo = persona.correo;
                personaAct.usuario = persona.usuario;
                personaAct.contraseña = persona.contraseña;
                personaAct.cve_tipo_usu = persona.cve_tipo_usu;

            }

            else
            {
                persona.id_persona = obtMaxIdPersona();
                entidad.PERSONAs.Add(persona);
            }

            entidad.SaveChanges();

            return true;
            }
            catch(Exception e){
              return false;
            }
        }

        protected int obtMaxIdPersona()
        {
            System.Nullable<Int32> id_persona = null;
            try
            {
                id_persona = (from ia in entidad.PERSONAs select (int?)ia.id_persona).Max();
                if (id_persona == null)
                    id_persona = 0;
            }
            catch (Exception ex)
            {
                id_persona = null;
            }
            return Convert.ToInt16(id_persona) + 1;
        }


    }
}