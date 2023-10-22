using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class UsuarioCls
    {
        public int UsuarioID { get; set; } 
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public int RolID { get; set; }
    }
    public class UsuarioConRolCls : UsuarioCls
    {
        public string Rol { get; set; }
    }


}
