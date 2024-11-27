using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Venta
{
    public class entAlquilerMaquinaria
    {
        public int idMaquinaria {  get; set; }

        public string nombre { get; set; }

        public DateTime fechaInicio { get; set; }

        public DateTime fechaFin {  get; set; }


        public int cantidad { get; set; }

        public bool operador { get; set; }
    }
}
