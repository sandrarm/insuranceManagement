//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaSeguros
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONA
    {
        public PERSONA()
        {
            this.POLIZAs = new HashSet<POLIZA>();
        }
    
        public int id_persona { get; set; }
        public string nombre { get; set; }
        public string ape_pat { get; set; }
        public string ape_mat { get; set; }
        public string cp { get; set; }
        public string calle { get; set; }
        public short numero { get; set; }
        public string colonia { get; set; }
        public string delegacion { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int cve_tipo_usu { get; set; }
    
        public virtual AJUSTADOR AJUSTADOR { get; set; }
        public virtual TIPOUSUARIO TIPOUSUARIO { get; set; }
        public virtual ICollection<POLIZA> POLIZAs { get; set; }
    }
}