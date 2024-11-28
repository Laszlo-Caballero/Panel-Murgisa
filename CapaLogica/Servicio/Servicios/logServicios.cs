using CapaAccesoDatos.Servicio.Servicios;
using CapaEntidad.Servicio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio.Servicios
{
    public class logServicios
    {
        private static readonly logServicios _instancia = new logServicios();

        public static logServicios Instancia
        {
            get { return _instancia; }
        }

        public List<entServicios> listarServicios()
        {
            return datServicios.Instancia.listarServicios();
        }

        public bool agregarServicios(entServicios nuevo)
        {
            return datServicios.Instancia.agregarServicio(nuevo);
        }

        public bool actualizarServicios(entServicios nuevo)
        {
            return datServicios.Instancia.actualizarServicio(nuevo);
        }

        public bool deshablitarServicio(int id)
        {
            return datServicios.Instancia.deshabilitarServicio(id);
        }
    }
}