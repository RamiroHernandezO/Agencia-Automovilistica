using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ServicioRefaccionesCls
    {
        public int ServicioID { get; set; }
        public int RefaccionID { get; set; }
        public int Cantidad { get; set; }

    }

    public class ServicioRefaccionesDetalladoCls
    {
        public int ServicioID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Dueño { get; set; }
        public DateTime FechaServicio { get; set; }
        public string Refaccion { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
