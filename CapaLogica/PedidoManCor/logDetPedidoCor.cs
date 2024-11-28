using CapaAccesoDatos.PedidoManCor;
using CapaEntidad.PedidoManCor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.PedidoManCor
{
    public class logDetPedidoCor
    {
        private static readonly logDetPedidoCor _instancia = new logDetPedidoCor();

        public static logDetPedidoCor Instancia
        {
            get { return _instancia; }
        }


        public bool agregarDetOrdenCorr(int maq, entPedidoManCor pedido, List<entDetPedidoCorr> detalle)
        {
            logPedidoManCor.Instancia.agregarPedidoManCor(pedido, maq);
            int id = logPedidoManCor.Instancia.ultimoPedido();
            return datDetPedidoCorr.Instancia.agregarDetOrdenCorr(detalle, id);
        }


        public bool deshablitarDetOrdenCorr(int id)
        {
            return datDetPedidoCorr.Instancia.deshabilitarDetOrdenCorr(id);
        }
    }
}