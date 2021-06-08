using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSeguros.ClasesNegocio
{
    public class SiniestroN
    {

        segurosEntities entidad = new segurosEntities();
        SINIESTRO siniestro = new SINIESTRO();
        

        public string obtListSiniestros()
        {

            string query = "SELECT SINIESTRO.id_siniestro, SINIESTRO.num_poliza, POLIZA.polizaseg, POLIZA.placas, PERSONA.nombre, PERSONA.ape_pat, PERSONA.ape_mat, ORDEN.id_orden  FROM SINIESTRO INNER JOIN POLIZA ON SINIESTRO.num_poliza = POLIZA.num_poliza INNER JOIN PERSONA ON PERSONA.id_persona = POLIZA.id_persona LEFT OUTER JOIN ORDEN ON ORDEN.id_siniestro = siniestro.id_siniestro WHERE ((PERSONA.nombre LIKE '%' + @nombre + '%') OR (PERSONA.ape_pat LIKE '%' + @nombre + '%') OR (PERSONA.ape_mat LIKE '%' + @nombre + '%'))AND(POLIZA.polizaseg LIKE '%' + @poliza + '%')AND(POLIZA.placas LIKE '%' + @placas + '%')";
            return query;
        }

        public string EliminaSiniestro(int id_siniestro)
        {
            string sqlBorrar = "DELETE FROM ORDEN WHERE ORDEN.id_siniestro IN(SELECT SINIESTRO.id_siniestro FROM SINIESTRO INNER JOIN ORDEN ON ORDEN.id_siniestro = SINIESTRO.id_siniestro WHERE SINIESTRO.id_siniestro="+id_siniestro+");"+"DELETE FROM SINIESTRO WHERE SINIESTRO.id_siniestro = " + id_siniestro + ";";
            return sqlBorrar;

        }
        public string ListaGravedad()
        {
            string sql = "SELECT cve_grave_les, desc_grave_les FROM GRAVEDADLESIONES;";
            return sql;
        }
        public SINIESTRO obtieneSiniestro(int id_siniestro)
        {

            SINIESTRO sini = entidad.SINIESTROes.Find(id_siniestro);
            return sini;
        }
                
        public bool agregarSINIESTRO(SINIESTRO siniestro, bool actualiza)
        {

            SINIESTRO siniestroAct;
             try
            {
            if (actualiza)
            {
                siniestroAct = entidad.SINIESTROes.First(p => p.id_siniestro == siniestro.id_siniestro);
                siniestroAct.edo_chofer = siniestro.edo_chofer;
                siniestroAct.condi_clima = siniestro.condi_clima;
                siniestroAct.condi_clima = siniestro.condi_terreno;
                siniestroAct.importe = siniestro.importe;
                siniestroAct.video = siniestro.video;
                siniestroAct.cp = siniestro.cp;
                siniestroAct.calle = siniestro.calle;
                siniestroAct.numero = siniestro.numero;
                siniestroAct.colonia = siniestro.colonia;
                siniestroAct.delegacion = siniestro.delegacion;
                siniestroAct.tipo_accidente = siniestro.tipo_accidente;
                siniestroAct.num_lesionado = siniestro.num_lesionado;
                siniestroAct.cve_grave_les = siniestro.cve_grave_les;
                siniestroAct.num_poliza = siniestro.num_poliza;
                siniestroAct.video = siniestro.video;
               
            }

            else
            {
                siniestro.id_siniestro= obtMaxIdSiniestro();
                entidad.SINIESTROes.Add(siniestro);
                
            }

            entidad.SaveChanges();

            return true;
            }
            catch(Exception e){
              return false;
            }
        }

        protected int obtMaxIdSiniestro()
        {
            System.Nullable<Int32> id_siniestro = null;
            try
            {
                id_siniestro = (from ia in entidad.SINIESTROes select (int?)ia.id_siniestro).Max();
                if (id_siniestro == null)
                    id_siniestro = 0;
            }
            catch (Exception ex)
            {
                id_siniestro = null;
            }
            return Convert.ToInt16(id_siniestro) + 1;
        }


    }
}