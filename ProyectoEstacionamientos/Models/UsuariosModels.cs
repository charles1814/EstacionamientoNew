using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoEstacionamientos.Models
{
    public class UsuariosModels
    {
        public int Cliente { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
    public class DatosUsuarios
    {
        public static int Cliente;
        public static string Nombre;
        public static int Nivel;
    }
}