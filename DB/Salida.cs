using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Nexus.DB
{
   public class Salida
    {
        [Key]
        public int IDSalida { get; set; }
        public int IDproducto { get; set; }
        public String Nombre { get; set; }
        public int IDproveedor { get; set; }
        public int cantidad { get; set; }
    }
}
