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
    
    public partial class docente_curso
    {
        public int id { get; set; }
        public int docente_id { get; set; }
        public int curso_id { get; set; }
    
        public virtual curso curso { get; set; }
        public virtual docente docente { get; set; }
    }
}
