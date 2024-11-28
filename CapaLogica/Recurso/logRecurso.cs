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

        public List<entRecurso> listarRecursoTipo(entTipoRecurso tipo)
        {
            return datRecurso.Instancia.listarRecursoTipo(tipo);
        }

        public List<entRecurso> listarMaquinaria()
        {
            return datRecurso.Instancia.listarMaquinaria();
        }
    }
}