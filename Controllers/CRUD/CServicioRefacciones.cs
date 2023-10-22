using Database.Entities;
using Models.Models;
using System.Collections.Generic;

namespace Controllers.CRUD
{
    public class CServicioRefacciones
    {
        ServicioRefacciones CservicioRefacciones = new ServicioRefacciones();

        public List<ServicioRefaccionesCls> Consultar()
        {
            return CservicioRefacciones.Consultar();
        }

        public List<ServicioRefaccionesDetalladoCls> ConsultarDetallado()
        {
            return CservicioRefacciones.ConsultarDetallado();
        }

        public void Insertar(ServicioRefaccionesCls servicioRefaccion)
        {
            CservicioRefacciones.Insertar(servicioRefaccion);
        }

        public void Actualizar(ServicioRefaccionesCls servicioRefaccion)
        {
            CservicioRefacciones.Actualizar(servicioRefaccion);
        }

        public void Eliminar(int servicioID, int refaccionID)
        {
            CservicioRefacciones.Eliminar(servicioID, refaccionID);
        }
    }
}
