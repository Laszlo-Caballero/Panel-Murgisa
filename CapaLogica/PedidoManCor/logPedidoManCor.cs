using CapaAccesoDatos.PedidoManCor;
using CapaEntidad.PedidoManCor;
using CapaLogica.Recurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.PedidoManCor
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

        public bool agregarPedidoManCor(entPedidoManCor nuevo, int id)
        {
            logRecurso.Instancia.actualizarDisponibilidad(id);
            return datPedidoManCor.Instancia.agregarPedidoManCor(nuevo);
        }

        public bool deshablitarPedidoManCor(int id)
        {
            datDetPedidoCorr.Instancia.deshabilitarDetOrdenCorr(id);
            return datPedidoManCor.Instancia.deshabilitarPedidoManCor(id);
        }
        public int ultimoPedido()
        {
            return datPedidoManCor.Instancia.ultimoPedido();
        }

    }
}