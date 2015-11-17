using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.DB
{
   public class Compra
    {
        public int ID { get; set; } 
        public int IDCompra { get; set; }
        public int Proveedor { get; set; }
        public int Producto { get; set; }
        public int IDProducto { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }
    }
}
