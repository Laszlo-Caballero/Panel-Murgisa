using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.PedidoManCor
{
    public class entDetOrdenCorr
    {
        public int id {  get; set; }

        public int pedido { get; set; }

        public int mantenimiento { get; set; }

        public string nombre { get; set; }

        public bool estado { get; set; }

    }
}
