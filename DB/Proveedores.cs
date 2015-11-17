using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Nexus.DB
{
    public class Proveedores
    {
        [Key]
        public int IDProveedor { get; set; }
        public String NombreProveedor { get; set; }
        public String DireccionProveedor { get; set; }
        public String NumeroTelProveedor { get; set; }
        public String CiudadProveedor { get; set; }
        public int DepartamentoID { get; set; }
        public String PaisProveedor { get; set; }
        public String CorreoProveedor { get; set; }
    }
}
