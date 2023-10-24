using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ServicioCls
    {
        public int ServicioID { get; set; } 
        public int VehiculoID { get; set; } 
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; } 
    }

    public class ServicioConVehiculoCls : ServicioCls
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Dueño { get; set; }
    }
    public class EstatusContadorCls
    {
        public string Estatus { get; set; }
        public int Cantidad { get; set; }
    }
}
