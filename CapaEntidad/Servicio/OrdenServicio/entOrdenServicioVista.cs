using CapaEntidad.Recurso;
using CapaEntidad.Servicio.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Servicio.OrdenServicio
{
    public class entOrdenServicioVista
    {
        public int id { get; set; }

        public int venta { get; set; }

        public string nombre { get; set; }

        public string dni { get; set; }

        public DateTime fecha { get; set; }

        public List<entDetalleVenta> recursos { get; set; } = new List<entDetalleVenta>();
        public bool estado { get; set; }

    }
}
