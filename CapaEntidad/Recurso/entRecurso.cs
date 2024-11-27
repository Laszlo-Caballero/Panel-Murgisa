using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Recurso
{
    public class entRecurso
    {
        public int idRecurso { get; set; }

        public int idTipoRecurso { get; set; }

        public int idDisponiblidad { get; set; }

        public int idCondicion { get; set; }

        public int idProveedor { get; set; }

        public string nombre { get; set; }

        public bool estado { get; set; }

        public int cantidad { get; set; }

        public float precio { get; set; }
    }
}
