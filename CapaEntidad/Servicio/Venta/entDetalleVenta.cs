using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Servicio.Venta
{
    public class entDetalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int idRecurso { get; set; }
        public string tipo { get; set; }

        public string disponibilidad { get; set; }

        public string condicion { get; set; }

        public string razSocial { get; set; }

        public string nombre { get; set; }

        public float precio { get; set; }

        public bool estado { get; set; } = true;
    }
}
