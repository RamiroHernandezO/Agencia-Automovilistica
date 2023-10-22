using Database.Entities;
using Models.Models;
using System.Collections.Generic;

namespace Controllers.CRUD
{
    public class CRefacciones
    {
        Refacciones refaccionesData = new Refacciones();

        public List<RefaccionesCls> Consultar()
        {
            return refaccionesData.Consultar();
        }

        public void Insertar(RefaccionesCls refaccion)
        {
            refaccionesData.Insertar(refaccion);
        }

        public void Actualizar(RefaccionesCls refaccion)
        {
            refaccionesData.Actualizar(refaccion);
        }

        public void Eliminar(int refaccionID)
        {
            refaccionesData.Eliminar(refaccionID);
        }

    }
}
