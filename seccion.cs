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
    
    public partial class seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seccion()
        {
            this.matricula = new HashSet<matricula>();
        }
    
        public int id { get; set; }
        public string nombre_seccion { get; set; }
        public int docente_id { get; set; }
        public int curso_id { get; set; }
        public int horario_id { get; set; }
    
        public virtual curso curso { get; set; }
        public virtual docente docente { get; set; }
        public virtual horario horario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<matricula> matricula { get; set; }
    }
}
