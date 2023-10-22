using Database.Entities;
using Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers.CRUD
{
    public class CUsuario
    {
        Usuario Cusuario = new Usuario();

        public List<UsuarioCls> Consultar()
        {
            return Cusuario.Consultar();
        }

        public List<UsuarioConRolCls> ConsultarConRol()
        {
            return Cusuario.ConsultarConRol();
        }

        public void Insertar(UsuarioCls usuario)
        {
            Cusuario.Insertar(usuario);
        }

        public void Actualizar(UsuarioCls usuario)
        {
            Cusuario.Actualizar(usuario);
        }

        public void Eliminar(int usuarioID)
        {
            Cusuario.Eliminar(usuarioID);
        }

    }
}
