using System.Collections.Generic;
using System.Linq;
using Database.Entities;
using Models.Models;

namespace Controllers.CRUD
{
    public class CVehiculo
    {
        Vehiculo Cvehiculo = new Vehiculo();

        public List<VehiculoCls> Consultar()
        {
            return Cvehiculo.Consultar();
        }

        public void Insertar(VehiculoCls vehiculo)
        {
            Cvehiculo.Insertar(vehiculo);
        }

        public void Actualizar(VehiculoCls vehiculo)
        {
            Cvehiculo.Actualizar(vehiculo);
        }

        public void Eliminar(int vehiculoID)
        {
            Cvehiculo.Eliminar(vehiculoID);
        }
    }
}
