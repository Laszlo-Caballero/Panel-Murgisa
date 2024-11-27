using CapaAccesoDatos.Venta;
using CapaEntidad.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Venta
{
    public class logTipoRecurso
    {
        private static readonly logTipoRecurso _instancia = new logTipoRecurso();

        public static logTipoRecurso Instancia
        {
            get { return _instancia; }
        }
        public List<entTipoRecurso> listarTipoRecurso()
        {
            return datTipoRecurso.Instancia.listarTipoRecurso();
        }

        public bool agregarTipoRecurso(entTipoRecurso nuevo)
        {
            return datTipoRecurso.Instancia.agregarTipoRecurso(nuevo);
        }

        public bool actualizarTipoRecurso(entTipoRecurso nuevo)
        {
            return datTipoRecurso.Instancia.actualizarTipoRecurso(nuevo);
        }

        public bool deshablitarTipoRecurso(int id)
        {
            return datTipoRecurso.Instancia.deshabilitarTipoRecurso(id);
        }
    }
}