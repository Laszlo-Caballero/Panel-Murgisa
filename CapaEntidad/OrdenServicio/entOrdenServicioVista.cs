using CapaEntidad.Recurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.OrdenServicio
{
    public class entOrdenServicioVista
    {
        public int id {  get; set; }

        public int venta {  get; set; }

        public string nombre { get; set; }

        public string dni { get; set; }

        public DateTime fecha { get; set; }

        public List<entRecurso> recursos { get; set; } = new List<entRecurso>();
        public bool estado { get; set; }

    }
}
