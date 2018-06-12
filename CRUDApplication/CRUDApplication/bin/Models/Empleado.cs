using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDApplication.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


    }
}