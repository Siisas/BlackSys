//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackSys.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Inventario
    {
        [Key]
        public int id_Inventartio { get; set; }
        public Nullable<int> Producto_id_producto { get; set; }
        public Nullable<int> CantidadEntrada { get; set; }
        public Nullable<int> CantidadSalidad { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
