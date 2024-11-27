using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.OrdenServicio
{
    public class entOrdenServicio
    {   
        public int id { get; set; }
        public int idVenta { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool estado { get; set; }
    }
}
        