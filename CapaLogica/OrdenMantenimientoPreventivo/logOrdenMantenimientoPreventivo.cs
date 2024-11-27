using CapaAccesoDatos.OrdenMantenimientoPreventivo;
using CapaEntidad.OrdenMantenimientoPreventivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.OrdenMantenimientoPreventivo
{
    public class logOrdenMantenimientoPreventivo
    {
        private static readonly logOrdenMantenimientoPreventivo _instancia = new logOrdenMantenimientoPreventivo();

        public static logOrdenMantenimientoPreventivo Instancia
        {
            get { return _instancia; }
        }
        public List<entOrdenMantenimientoPreventivo> listarOrdenMantenimientoPreventivo()
        {
            return datOrdenMantenimientoPreventivo.Instancia.listarOrdenMantenimientoPreventivo();
        }

        public bool agregarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            return datOrdenMantenimientoPreventivo.Instancia.agregarOrdenMantenimientoPreventivo(nuevo);
        }

        public bool actualizarOrdenMantenimientoPreventivo(entOrdenMantenimientoPreventivo nuevo)
        {
            return datOrdenMantenimientoPreventivo.Instancia.actualizarOrdenMantenimientoPreventivo(nuevo);
        }

        public bool deshablitarServicio(int id)
        {
            return datOrdenMantenimientoPreventivo.Instancia.deshabilitarOrdenMantenimientoPreventivo(id);
        }
    }
}