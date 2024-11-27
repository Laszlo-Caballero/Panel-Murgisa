using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Personal
{
    public class entPersonal
    {
        public int id {  get; set; }

        public int idCargo { get; set; }
        public int idProf { get; set; }
        public int idDepa { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public float sueldo {  get; set; }
        public bool estadoo { get; set; }

    }
}
        