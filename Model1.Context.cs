﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asvii
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sistemaacademicobdEntities1 : DbContext
    {
        public sistemaacademicobdEntities1()
            : base("name=sistemaacademicobdEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrador> administrador { get; set; }
        public virtual DbSet<alumno> alumno { get; set; }
        public virtual DbSet<alumno_curso> alumno_curso { get; set; }
        public virtual DbSet<calificacion> calificacion { get; set; }
        public virtual DbSet<curso> curso { get; set; }
        public virtual DbSet<docente> docente { get; set; }
        public virtual DbSet<docente_curso> docente_curso { get; set; }
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<matricula> matricula { get; set; }
        public virtual DbSet<seccion> seccion { get; set; }
        public virtual DbSet<tipo_nota> tipo_nota { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
