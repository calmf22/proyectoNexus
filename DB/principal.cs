using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DB
{
   public class principal:DbContext
    {
        //public DbSet<Empleado> Empleados { get; set; }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Proveedores> Proveedoress { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<Departamentos> Departamentoss { get; set; }
        
    }
}
