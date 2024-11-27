using CapaAccesoDatos.Disponibilidad;
using CapaEntidad.Disponibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Disponibilidad
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

        public bool agregarDisponibilidad(entDisponibilidad nuevo)
        {
            return datDisponibilidad.Instancia.agregarDisponibilidad(nuevo);
        }

        public bool actualizarDisponibilidad(entDisponibilidad nuevo)
        {
            return datDisponibilidad.Instancia.actualizarDisponibilidad(nuevo);
        }

        public bool deshablitarDisponibilidad(int id)
        {
            return datDisponibilidad.Instancia.deshabilitarDisponibilidad(id);
        }
    }
}