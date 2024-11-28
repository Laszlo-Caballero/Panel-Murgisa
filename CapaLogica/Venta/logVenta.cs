using CapaAccesoDatos.Venta;
using CapaEntidad.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Venta
{
    public class logVenta
    {
        private static readonly logVenta _instancia = new logVenta();

        public static logVenta Instancia
        {
            get { return _instancia; }
        }
        public List<entVentaVista> listarVenta()
        {
            return datVenta.Instancia.listarVenta();
        }
        public List<entVentaVista> listarVentaCliente(string dni)
        {
            return datVenta.Instancia.listarVentaCliente(dni);
        }

        public List<entDetalleVenta> listarDetalleVentas(int id)
        {
            return datVenta.Instancia.listarDetalleVenta(id);
        }

        public List<entAsignacionPersonal> listarPersonal(int id)
        {
            return datVenta.Instancia.listarPersonal(id);
        }

        public bool agregarVenta(entVenta nuevo)
        {
            return datVenta.Instancia.agregarVenta(nuevo);
        }

        public bool deshablitarVenta(int id)
        {
            return datVenta.Instancia.deshabilitarVenta(id);
        }

        public List<entVenta> listarVentaCliente(int id)
        {
            return datVenta.Instancia.listarVentaCliente(id);
        }
    }
}