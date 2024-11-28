using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.PedidoManCor
{
    public class entPedidoManCor
    {
        public int id {  get; set; }

        public int recurso { get; set; }

        public string nombre { get; set; }

        public string proveedor { get; set; }

        public DateTime fecha { get; set; }

        public string prioridad { get; set; }

        public bool estado { get; set; }
    }
}
        