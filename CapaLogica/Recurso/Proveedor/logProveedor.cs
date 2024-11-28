using CapaAccesoDatos.Recurso.Proveedor;
using CapaEntidad.Recurso.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Recurso.Proveedor
{
    public class logProveedor
    {
        private static readonly logProveedor _instancia = new logProveedor();

        public static logProveedor Instancia
        {
            get { return _instancia; }
        }
        public List<entProveedor> listarProveedor()
        {
            return datProveedor.Instancia.listarProveedor();
        }

        public bool agregarProveedor(entProveedor nuevo)
        {
            return datProveedor.Instancia.agregarProveedor(nuevo);
        }

        public bool actualizarProveedor(entProveedor nuevo)
        {
            return datProveedor.Instancia.actualizarProveedor(nuevo);
        }

        public bool deshablitarProveedor(int id)
        {
            return datProveedor.Instancia.deshabilitarProveedor(id);
        }
    }
}