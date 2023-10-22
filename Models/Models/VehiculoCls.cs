using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class VehiculoCls
    {
        public int VehiculoID { get; set; } 
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Dueño { get; set; }
        public DateTime ProximoServicio { get; set; }
    }
}
