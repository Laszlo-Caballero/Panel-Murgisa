using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Personal
{
    public class entCargo
    {
        public int id { get; set; }

        public string cargo { get; set; }

        public string desc { get; set; }

        public float sueldo { get; set; }

        public bool estado { get; set; }
    }
}
