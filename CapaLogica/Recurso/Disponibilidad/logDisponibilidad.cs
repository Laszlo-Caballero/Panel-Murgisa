using CapaAccesoDatos.Recurso.Disponibilidad;
using CapaEntidad.Recurso.Disponibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Recurso.Disponibilidad
{
    public class logDisponibilidad
    {
        private static readonly logDisponibilidad _instancia = new logDisponibilidad();

        public static logDisponibilidad Instancia
        {
            get { return _instancia; }
        }
        public List<entDisponibilidad> listarDisponibilidad()
        {
            return datDisponibilidad.Instancia.listarDisponibilidad();
        }

        public bool agregarDisponibilidad(entDisponibilidad disponibilidad)
        {
            return datDisponibilidad.Instancia.agregarDisponibilidad(disponibilidad);
        }

        public bool actualizarDisponibilidad(entDisponibilidad disponibilidad)
        {
            return datDisponibilidad.Instancia.actualizarDisponibilidad(disponibilidad);
        }

        public bool deshablitarDisponibilidad(entDisponibilidad disponibilidad)
        {
            return datDisponibilidad.Instancia.deshabilitarDisponibilidad(disponibilidad);
        }
    }
}