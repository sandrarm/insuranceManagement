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
    
    public partial class AUTO
    {
        public AUTO()
        {
            this.POLIZAs = new HashSet<POLIZA>();
        }
    
        public string placas { get; set; }
        public string marca { get; set; }
        public string submarca { get; set; }
        public short año { get; set; }
    
        public virtual ICollection<POLIZA> POLIZAs { get; set; }
    }
}