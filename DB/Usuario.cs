using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nexus.DB
{
   public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String NombreUsuario { get; set; }
        public String Contraseña { get; set; } 

    }
}
