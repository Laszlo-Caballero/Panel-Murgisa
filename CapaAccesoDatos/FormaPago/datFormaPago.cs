using CapaEntidad.FormaPago;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.FormaPago
{
    public class datFormaPago
    {
        private static readonly datFormaPago _instancia = new datFormaPago();

        public static datFormaPago Instancia
        {
            get { return _instancia; }
        }
    }
}