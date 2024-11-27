using CapaAccesoDatos.Recurso;
using CapaEntidad.Recurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Recurso
{
    public class logRecurso
    {
        private static readonly logRecurso _instancia = new logRecurso();

        public static logRecurso Instancia
        {
            get { return _instancia; }
        }
        public List<entRecurso> listarRecurso()
        {
            return datRecurso.Instancia.listarRecurso();
        }

        public bool agregarRecurso(entRecurso nuevo)
        {
            return datRecurso.Instancia.agregarRecurso(nuevo);
        }

        public bool actualizarRecurso(entRecurso nuevo)
        {
            return datRecurso.Instancia.actualizarRecurso(nuevo);
        }

        public bool deshablitarRecurso(int id)
        {
            return datRecurso.Instancia.deshabilitarRecurso(id);
        }
    }
}