using CapaAccesoDatos.Mantenimiento.PedidoManCor;
using CapaEntidad.Mantenimiento.PedidoManCor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Mantenimiento.PedidoManCor
{
    public class logPedidoManCor
    {
        private static readonly logPedidoManCor _instancia = new logPedidoManCor();

        public static logPedidoManCor Instancia
        {
            get { return _instancia; }
        }
        public List<entPedidoManCor> listarPedidoManCor()
        {
            return datPedidoManCor.Instancia.listarPedidoManCor();
        }

        public bool agregarPedidoManCor(entPedidoManCor nuevo)
        {
            return datPedidoManCor.Instancia.agregarPedidoManCor(nuevo);
        }

        public bool deshablitarPedidoManCor(int id)
        {
            return datPedidoManCor.Instancia.deshabilitarPedidoManCor(id);
        }
        public int ultimoPedido()
        {
            return datPedidoManCor.Instancia.ultimoPedido();
        }

    }
}