using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class EntregaCls
    {
        public int ServicioID { get; set; }
        public int AdminID { get; set; }
        public DateTime FechaEntrega { get; set; }
    }

    public class EntregaDetalladoCls
    {
        public int ServicioID { get; set; }
        public DateTime FechaServicio { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaEntrega { get; set; }
    }

}
