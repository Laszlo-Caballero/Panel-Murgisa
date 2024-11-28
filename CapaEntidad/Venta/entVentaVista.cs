using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Venta
{
    public class entVentaVista
    {
        public int idVenta {  get; set; }


        public string servicio {  get; set; }

        public string nombre { get; set; }

        public string dni { get; set; }

        public DateTime inicio {  get; set; }

        public DateTime fin {  get; set; }

        public DateTime venta { get; set; }

        public bool estado { get; set; }
    }
}
