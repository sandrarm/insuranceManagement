using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSeguros.ClasesNegocio
{
    public class PolizaN
    {
    
        segurosEntities entidad = new segurosEntities();
        POLIZA poliza = new POLIZA();
        AUTO auto = new AUTO();

         public string obtListPolizasT()
        {

            string query = "SELECT POLIZA.num_poliza, POLIZA.placas, POLIZA.polizaseg, PERSONA.nombre, PERSONA.ape_pat, PERSONA.ape_mat, POLIZA.id_persona FROM PERSONA INNER JOIN POLIZA ON PERSONA.id_persona = POLIZA.id_persona INNER JOIN AUTO ON POLIZA.placas = AUTO.placas";
            return query;
        }

         public string obtListPolizasBusca(string pol)
         {
             //falta**
             string query = "SELECT POLIZA.num_poliza, POLIZA.placas, PERSONA.nombre, POLIZA.polizaseg, PERSONA.ape_pat, PERSONA.ape_mat, POLIZA.id_persona FROM PERSONA INNER JOIN POLIZA ON PERSONA.id_persona = POLIZA.id_persona INNER JOIN AUTO ON POLIZA.placas = AUTO.placas where POLIZA.polizaseg='"+pol+"';";
             return query;
         }
            
            public string obtListPolizas(int id_persona)
        {

            string query = "SELECT POLIZA.num_poliza, POLIZA.polizaseg, AUTO.placas, AUTO.marca, AUTO.submarca, AUTO.año FROM POLIZA INNER JOIN AUTO ON POLIZA.placas = AUTO.placas WHERE POLIZA.id_persona ="+id_persona+";";
            return query;
        }

        public string EliminaPoliza( int num_poliza, string placas)
        {
            
            string sqlBorrar = "DELETE FROM ORDEN WHERE id_siniestro IN (SELECT SINIESTRO.id_siniestro FROM SINIESTRO INNER JOIN ORDEN ON ORDEN.id_siniestro = SINIESTRO.id_siniestro INNER JOIN POLIZA ON POLIZA.num_poliza = SINIESTRO.num_poliza WHERE POLIZA.num_poliza="+num_poliza+");"+"DELETE FROM SINIESTRO WHERE SINIESTRO.id_siniestro IN(SELECT SINIESTRO.id_siniestro FROM SINIESTRO INNER JOIN POLIZA ON POLIZA.num_poliza = SINIESTRO.num_poliza WHERE POLIZA.num_poliza="+num_poliza+");"+"DELETE FROM POLIZA WHERE num_poliza = " + num_poliza + "; DELETE FROM AUTO WHERE AUTO.placas ='" + placas + "'; ";
            return sqlBorrar;

        }
        
        public POLIZA obtienePoliza(int num_poliza)
        {

            POLIZA po = entidad.POLIZAs.Find(num_poliza);
            return po;
        }

        public bool verifPoliza(int num_poliza)
        {

             POLIZA poliza =  new POLIZA();
            poliza = entidad.POLIZAs.Where(b => b.num_poliza == num_poliza)
                    .FirstOrDefault();

            if (poliza==null)
            {
                return true;
            }
            else 
                return false;
        }

        public POLIZA obtPoliza(string pol)
        {

            POLIZA poliza = new POLIZA();
            poliza = entidad.POLIZAs.Where(b => b.polizaseg == pol)
                    .FirstOrDefault();

           return poliza;
        }
        public AUTO obtieneAuto(string placas)
        {

            AUTO a = entidad.AUTOes.Find(placas);
            return a;
        }

        public bool agregarPoliza(POLIZA poliza, AUTO auto, bool actualiza) {

            POLIZA polizaAct;
            AUTO autoAct;
            try
            {
            if (actualiza)
            {
                polizaAct = entidad.POLIZAs.First(p => p.num_poliza == poliza.num_poliza);
                polizaAct.polizaseg = poliza.polizaseg;
                autoAct = entidad.AUTOes.First(a => a.placas == auto.placas);
                autoAct.marca = auto.marca;
                autoAct.submarca = auto.submarca;
                autoAct.año = auto.año;
            }

            else
            {
                poliza.num_poliza = obtMaxIdPoliza();
                entidad.POLIZAs.Add(poliza);
                entidad.AUTOes.Add(auto);
            }

                entidad.SaveChanges();

                return true;
            }
            catch(Exception e){
                return false;
            }
        }


        public bool ValidaPolizasCte(int id_persona)
        {

            POLIZA poliza = new POLIZA();
            poliza = entidad.POLIZAs.Where(b =>b.id_persona == id_persona)
                    .FirstOrDefault();
            if (poliza == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected int obtMaxIdPoliza()
        {
            System.Nullable<Int32> id_pol = null;
            try
            {
                id_pol = (from ia in entidad.POLIZAs select (int?)ia.num_poliza).Max();
                if (id_pol == null)
                    id_pol = 0;
            }
            catch (Exception ex)
            {
                id_pol = null;
            }
            return Convert.ToInt16(id_pol) + 1;
        }
    }
}