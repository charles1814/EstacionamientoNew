//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoEstacionamientos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarifas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarifas()
        {
            this.Vehiculos = new HashSet<Vehiculos>();
        }
    
        public int idtarifa { get; set; }
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public Nullable<int> tolerancia { get; set; }
        public Nullable<int> inicio { get; set; }
        public Nullable<int> fraccion { get; set; }
        public string tarifaxdia { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
