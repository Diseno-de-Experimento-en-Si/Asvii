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
    
    public partial class alumno_curso
    {
        public int id { get; set; }
        public int alumno_id { get; set; }
        public int curso_id { get; set; }
        public int calificacion_id { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual calificacion calificacion { get; set; }
        public virtual curso curso { get; set; }
    }
}
