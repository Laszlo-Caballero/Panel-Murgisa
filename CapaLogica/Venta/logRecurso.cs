using CapaAccesoDatos.Venta;
using CapaEntidad.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Venta
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

        public List<entRecurso> listarRecursoTipo(entTipoRecurso tipo)
        {
            return datRecurso.Instancia.listarRecursoTipo(tipo);
        }
    }
}