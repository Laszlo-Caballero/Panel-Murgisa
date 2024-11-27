using CapaAccesoDatos.PedidoMantenimientoCorrectivo;
using CapaEntidad.PedidoMantenimientoCorrectivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.PedidoMantenimientoCorrectivo
{
    public class logPedidoMantenimientoCorrectivo
    {
        private static readonly logPedidoMantenimientoCorrectivo _instancia = new logPedidoMantenimientoCorrectivo();

        public static logPedidoMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }
        public List<entPedidoMantenimientoCorrectivo> listarPedidoMantenimientoCorrectivo()
        {
            return datPedidoMantenimientoCorrectivo.Instancia.listarPedidoMantenimientoCorrectivo();
        }

        public bool agregarPedidoMantenimientoCorrectivo(entPedidoMantenimientoCorrectivo nuevo)
        {
            return datPedidoMantenimientoCorrectivo.Instancia.agregarPedidoMantenimientoCorrectivo(nuevo);
        }

        public bool actualizarPedidoMantenimientoCorrectivo(entPedidoMantenimientoCorrectivo nuevo)
        {
            return datPedidoMantenimientoCorrectivo.Instancia.actualizarPedidoMantenimientoCorrectivo(nuevo);
        }

        public bool deshablitarPedidoMantenimientoCorrectivo(int id)
        {
            return datPedidoMantenimientoCorrectivo.Instancia.deshabilitarPedidoMantenimientoCorrectivo(id);
        }
    }
}