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

        public bool agregarCondicion(entCondicion nuevo)
        {
            return datCondicion.Instancia.agregarCondicion(nuevo);
        }

        public bool actualizarCondicion(entCondicion nuevo)
        {
            return datCondicion.Instancia.actualizarCondicion(nuevo);
        }

        public bool deshablitarCondicion(int id)
        {
            return datCondicion.Instancia.deshabilitarCondicion(id);
        }
    }
}