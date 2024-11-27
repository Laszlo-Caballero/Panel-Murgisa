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
        public List<entVenta> listarVenta()
        {
            return datVenta.Instancia.listarVenta();
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