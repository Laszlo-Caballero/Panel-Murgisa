using CapaAccesoDatos.Recurso;
using CapaEntidad.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Recurso
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
    }
}