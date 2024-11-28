using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.PagoServicio
{
    public class entPagoServicio
    {
        public int id {  get; set; }
        public int idVenta { get; set; }
        public int idFormaPago { get; set; }
        public string nombre { get; set; }
        public string dni {  get; set; }
        public string correo { get; set; }
        public string tipo { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }

    }
}
        