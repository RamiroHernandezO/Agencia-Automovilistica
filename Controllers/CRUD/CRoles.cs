using Database.Entities;
using Models.Models;
using System.Collections.Generic;

namespace Controllers.CRUD
{
    public class CRoles
    {
        Roles Croles = new Roles();

        public List<RolesCls> Consultar()
        {
            return Croles.Consultar();
        }

        public void Insertar(RolesCls rol)
        {
            Croles.Insertar(rol);
        }

        public void Actualizar(RolesCls rol)
        {
            Croles.Actualizar(rol);
        }

        public void Eliminar(int rolID)
        {
            Croles.Eliminar(rolID);
        }

    }
}
