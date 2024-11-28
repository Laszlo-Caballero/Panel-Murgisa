using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Personal;
using CapaEntidad.Recurso;

namespace CapaEntidad.Venta
{
    public class entVenta
    {
        public int idVenta {  get; set; }

        public int idServicio { get; set; }

        public int idCliente { get; set; }

        public DateTime fIncioServicio { get; set; }

        public DateTime fFinServicio { get; set; }

        public DateTime fechaVenta { get; set; }

        public bool estado {  get; set; }

        public List<entRecurso> recursos  { get; set; } = new List<entRecurso>();

        public List<entPersonalVista> personal { get; set; } = new List<entPersonalVista>();
    }
}
        