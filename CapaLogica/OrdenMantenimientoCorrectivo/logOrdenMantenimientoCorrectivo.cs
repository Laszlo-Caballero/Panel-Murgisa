using CapaAccesoDatos.OrdenMantenimientoCorrectivo;
using CapaEntidad.OrdenMantenimientoCorrectivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.OrdenMantenimientoCorrectivo
{
    public class logOrdenMantenimientoCorrectivo
    {
        private static readonly logOrdenMantenimientoCorrectivo _instancia = new logOrdenMantenimientoCorrectivo();

        public static logOrdenMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }
        public List<entOrdenMantenimientoCorrectivo> listarOrdenMantenimientoCorrectivo()
        {
            return datOrdenMantenimientoCorrectivo.Instancia.listarOrdenMantenimientoCorrectivo();
        }

        public bool agregarOrdenMantenimientoCorrectivo(entOrdenMantenimientoCorrectivo nuevo)
        {
            return datOrdenMantenimientoCorrectivo.Instancia.agregarOrdenMantenimientoCorrectivo(nuevo);
        }

        public bool actualizarOrdenMantenimientoCorrectivo(entOrdenMantenimientoCorrectivo nuevo)
        {
            return datOrdenMantenimientoCorrectivo.Instancia.actualizarOrdenMantenimientoCorrectivo(nuevo);
        }

        public bool deshablitarServicio(int id)
        {
            return datOrdenMantenimientoCorrectivo.Instancia.deshabilitarOrdenMantenimientoCorrectivo(id);
        }
    }
}