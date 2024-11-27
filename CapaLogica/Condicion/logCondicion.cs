using CapaAccesoDatos.Condicion;
using CapaEntidad.Condicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Condicion
{
    public class logCondicion
    {
        private static readonly logCondicion _instancia = new logCondicion();

        public static logCondicion Instancia
        {
            get { return _instancia; }
        }
        public List<entCondicion> listarCondicion()
        {
            return datCondicion.Instancia.listarCondicion();
        }

        public bool agregarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.agregarCondicion(condicion);
        }

        public bool actualizarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.actualizarCondicion(condicion);
        }

        public bool deshablitarCondicion(entCondicion condicion)
        {
            return datCondicion.Instancia.deshabilitarCondicion(condicion);
        }
    }
}