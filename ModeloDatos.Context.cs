﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class segurosEntities : DbContext
    {
        public segurosEntities()
            : base("name=segurosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AJUSTADOR> AJUSTADORs { get; set; }
        public virtual DbSet<AUTO> AUTOes { get; set; }
        public virtual DbSet<EDOREPARACION> EDOREPARACIONs { get; set; }
        public virtual DbSet<GRAVEDADLESIONE> GRAVEDADLESIONES { get; set; }
        public virtual DbSet<ORDEN> ORDENs { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<SINIESTRO> SINIESTROes { get; set; }
        public virtual DbSet<TIPOUSUARIO> TIPOUSUARIOs { get; set; }
        public virtual DbSet<ZONALABORAL> ZONALABORALs { get; set; }
        public virtual DbSet<POLIZA> POLIZAs { get; set; }
    }
}