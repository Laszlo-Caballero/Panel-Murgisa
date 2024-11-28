using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Venta
{
    public class entAsignacionPersonal
    {
        public int idAsignacionPersonal {  get; set; }

        public int idPersonal {  get; set; }

        public string nombre {  get; set; }

        public string paterno { get; set; }

        public string materno {  get; set; }

        public string cargo {  get; set; }

        public float costo { get; set; }

        public bool estado { get; set; } = true;
    }
}
