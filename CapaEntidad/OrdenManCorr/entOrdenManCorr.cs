using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.OrdenManCorr
{
    public class entOrdenManCorr
    {
        public int id {  get; set; }

        public int pedido { get; set; }
        
        public string maquinaria { get; set; }

        public string proveedor { get; set; }

        public string ruc { get; set; }

        public DateTime fecha { get; set; }

        public bool estado { get; set; }

    }
}
        