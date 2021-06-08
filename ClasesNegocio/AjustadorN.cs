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
    public class AjustadorN
    {
        segurosEntities entidad = new segurosEntities();
        PERSONA persona = new PERSONA();


        public string obtListAjustadores()
        {

            string query = "SELECT AJUSTADOR.id_persona, AJUSTADOR.telefono, AJUSTADOR.hora_ent, AJUSTADOR.hora_sal, PERSONA.nombre, PERSONA.ape_pat, PERSONA.ape_mat, PERSONA.correo, PERSONA.usuario, ZONALABORAL.desc_zona FROM AJUSTADOR INNER JOIN PERSONA ON AJUSTADOR.id_persona = PERSONA.id_persona INNER JOIN ZONALABORAL ON AJUSTADOR.cve_zona= ZONALABORAL.cve_zona WHERE ((PERSONA.nombre LIKE '%' + @nombre + '%') OR (PERSONA.ape_pat LIKE '%' + @nombre + '%') OR (PERSONA.ape_mat LIKE '%' + @nombre + '%') )AND (ZONALABORAL.desc_zona LIKE '%' + @zona + '%') ";
            return query;
        }

        public string EliminaAjustador(int id_persona)
        {
            string sqlBorrar = "DELETE FROM AJUSTADOR WHERE AJUSTADOR.id_persona = " + id_persona + "; DELETE FROM PERSONA WHERE id_persona = "+id_persona+";";
            return sqlBorrar;

        }
        public string LisatZonas()
        {
            string sql = "SELECT cve_zona, desc_zona FROM ZONALABORAL;";
            return sql;
        }
        public AJUSTADOR obtieneAjustador(int id_ajust)
        {

            AJUSTADOR aj = entidad.AJUSTADORs.Find(id_ajust);
            return aj;
        }

        public PERSONA obtienePersona(int id_per)
        {

            PERSONA aj = entidad.PERSONAs.Find(id_per);
            return aj;
        }

        public bool agregarAjustador(PERSONA persona, AJUSTADOR ajustador, bool actualiza) {

            PERSONA personaAct;
            AJUSTADOR ajustadorAct;
            try
            {
                if (actualiza)
                {
                    personaAct = entidad.PERSONAs.First(p => p.id_persona == persona.id_persona);
                    ajustadorAct = entidad.AJUSTADORs.First(a => a.id_persona == ajustador.id_persona);
                    personaAct.nombre = persona.nombre;
                    personaAct.ape_pat = persona.ape_pat;
                    personaAct.ape_mat = personaAct.ape_mat;
                    personaAct.cp = persona.cp;
                    personaAct.calle = persona.calle;
                    personaAct.numero = persona.numero;
                    personaAct.colonia = persona.colonia;
                    personaAct.delegacion = persona.delegacion;
                    personaAct.correo = persona.correo;
                    personaAct.usuario = persona.usuario;
                    personaAct.contraseña = persona.contraseña;
                    personaAct.cve_tipo_usu = persona.cve_tipo_usu;
                    ajustadorAct.id_persona = ajustador.id_persona;
                    ajustadorAct.telefono = ajustador.telefono;
                    ajustadorAct.hora_ent = ajustador.hora_ent;
                    ajustadorAct.hora_sal = ajustador.hora_sal;
                    ajustadorAct.cve_zona = ajustador.cve_zona;
                }

                else
                {
                    persona.id_persona = obtMaxIdPersona();
                    entidad.PERSONAs.Add(persona);
                    ajustador.id_persona = persona.id_persona;
                    entidad.AJUSTADORs.Add(ajustador);
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
            return Convert.ToInt16(id_persona)+1;
        }


    }
}