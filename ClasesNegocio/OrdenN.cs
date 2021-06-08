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
    public class OrdenN
    {
        segurosEntities entidad = new segurosEntities();
        ORDEN persona = new ORDEN();

        public string obtListOrdenes(int id_persona)
        {

            string query = "SELECT SINIESTRO.id_siniestro, SINIESTRO.num_poliza, ORDEN.id_orden, ORDEN.taller, ORDEN.fec_ent, POLIZA.placas, EDOREPARACION.desc_edo_repa FROM PERSONA INNER JOIN POLIZA ON PERSONA.id_persona = POLIZA.id_persona INNER JOIN SINIESTRO ON POLIZA.num_poliza = SINIESTRO.num_poliza INNER JOIN ORDEN ON SINIESTRO.id_siniestro = ORDEN.id_siniestro INNER JOIN EDOREPARACION ON ORDEN.cve_edo_repa = EDOREPARACION.cve_edo_repa WHERE PERSONA.id_persona="+id_persona;

            return query;
        }

        public string ListaEdoRepara()
        {
            string sql = "SELECT cve_edo_repa, desc_edo_repa FROM EDOREPARACION;";
            return sql;
        }
        public ORDEN obtieneOrden(int id_orden)
        {
            ORDEN orden = entidad.ORDENs.Find(id_orden);
            return orden;
        }

         public bool agregarOrden(ORDEN orden, bool actualiza)
        {

           ORDEN ordenAct;
             try
            {
            if (actualiza)
            {
                ordenAct = entidad.ORDENs.First(p => p.id_orden == orden.id_orden);
                ordenAct.taller = orden.taller;
                ordenAct.fec_ent = orden.fec_ent;
                ordenAct.cve_edo_repa = orden.cve_edo_repa;
                ordenAct.id_siniestro = orden.id_siniestro;

            }

            else
            {
                orden.id_orden = obtMaxIdOrden();
                entidad.ORDENs.Add(orden);
            }

            entidad.SaveChanges();

            return true;
            }
            catch(Exception e){
              return false;
            }
        }

        protected int obtMaxIdOrden()
        {
            System.Nullable<Int32> id_orden = null;
            try
            {
                id_orden = (from or in entidad.ORDENs select (int?)or.id_orden).Max();
                if (id_orden == null)
                    id_orden = 0;
            }
            catch (Exception ex)
            {
                id_orden = null;
            }
            return Convert.ToInt16(id_orden) + 1;
        }


    }
}