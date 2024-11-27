using CapaAccesoDatos.FormaPago;
using CapaEntidad.FormaPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.FormaPago
{
    public class logFormaPago
    {
        private static readonly logFormaPago _instancia = new logFormaPago();

        public static logFormaPago Instancia
        {
            get { return _instancia; }
        }
    }
}