using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Servicio.OrdenServicio
{
    public class entOrdenServicio
    {
        public int id { get; set; }

        public int idVenta { get; set; }
        public DateTime fecha { get; set; }

        public bool estado { get; set; }


    }
}
