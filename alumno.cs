//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            this.alumno_curso = new HashSet<alumno_curso>();
        }
    
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string contrasenia { get; set; }
        public int matricula_id { get; set; }
        public int tipo_usuario_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumno_curso> alumno_curso { get; set; }
        public virtual matricula matricula { get; set; }
        public virtual tipo_usuario tipo_usuario { get; set; }
    }
}
