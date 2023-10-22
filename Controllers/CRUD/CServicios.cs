using Database.Entities;
using Models.Models;
using System.Collections.Generic;

namespace Controllers.CRUD
{
    public class CServicio
    {
        Servicios Cservicio = new Servicios();

        public List<ServicioCls> Consultar()
        {
            return Cservicio.Consultar();
        }

        public List<ServicioConVehiculoCls> ConsultarServiciosConVehiculos()
        {
            return Cservicio.ConsultarServiciosConVehiculos();
        }

        public void Insertar(ServicioCls servicio)
        {
            Cservicio.Insertar(servicio);
        }

        public void Actualizar(ServicioCls servicio)
        {
            Cservicio.Actualizar(servicio);
        }

        public void Eliminar(int servicioID)
        {
            Cservicio.Eliminar(servicioID);
        }
    }
}
