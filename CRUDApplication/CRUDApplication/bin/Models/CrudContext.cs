using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDApplication.Models
{
    public class CrudContext: DbContext
    {
        public CrudContext() : base("CRUDApplication")
        {

        }
        public DbSet<Empleado> Empleados { get; set; }
    }
}