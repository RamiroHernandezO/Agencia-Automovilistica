using Database.Entities;
using Models.Models;
using System.Collections.Generic;

namespace Controllers.CRUD
{
    public class CEntregas
    {
        Entregas entregasData = new Entregas();

        public List<EntregaCls> Consultar()
        {
            return entregasData.Consultar();
        }

        public List<EntregaDetalladoCls> ConsultarDetallado()
        {
            return entregasData.ConsultarDetallado();
        }

        public void Insertar(EntregaCls entrega)
        {
            entregasData.Insertar(entrega);
        }

        public void Actualizar(EntregaCls entrega)
        {
            entregasData.Actualizar(entrega);
        }

        public void Eliminar(int servicioID, int adminID)
        {
            entregasData.Eliminar(servicioID, adminID);
        }

    }
}
