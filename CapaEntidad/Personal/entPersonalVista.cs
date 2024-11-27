using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Personal
{
    public class entPersonalVista
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string cargo { get; set; }
        public string prof { get; set; }
        public string depa { get; set; }
        public float sueldo { get; set; }
        public bool estado { get; set; }
    }
}
