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
    
    public partial class ClientesTerceros
    {
        public int idclienteterc { get; set; }
        public int idcliente { get; set; }
        public int idvehiculo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual VehiculosClientes VehiculosClientes { get; set; }
    }
}