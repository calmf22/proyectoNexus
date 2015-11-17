using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nexus.DB
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public String NombreProducto { get; set; }
        public int precioUnitario { get; set; }
        public String UnidadMedida { get; set; }
        public string RutaImagen { get; set; }
    }
}
