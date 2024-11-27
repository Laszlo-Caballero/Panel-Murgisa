using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<entRecurso> recursos  { get; set; } = new List<entRecurso>();
    }
}
        