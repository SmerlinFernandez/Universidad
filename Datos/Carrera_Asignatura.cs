//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carrera_Asignatura
    {
        public int ID { get; set; }
        public int CodigoCarrera { get; set; }
        public int CodigoAsignatura { get; set; }
    
        public virtual Asignatura Asignatura { get; set; }
        public virtual Carrera Carrera { get; set; }
    }
}
