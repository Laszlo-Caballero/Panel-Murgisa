using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Mantenimiento.PedidoManCor
{
    public class entDetPedidoCorr
    {
        public int id { get; set; }

        public int pedido { get; set; }

        public int mantenimiento { get; set; }

        public bool estado { get; set; }

    }
}
