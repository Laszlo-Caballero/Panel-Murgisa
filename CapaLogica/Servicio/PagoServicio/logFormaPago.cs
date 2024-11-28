using CapaAccesoDatos.Servicio.PagoServicio;
using CapaEntidad.Servicio.PagoServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio.PagoServicio
{
    public class logFormaPago
    {
        private static readonly logFormaPago _instancia = new logFormaPago();

        public static logFormaPago Instancia
        {
            get { return _instancia; }
        }

        public List<entFormaPago> listarPagos()
        {
            return datFormaPago.Instancia.listarFormaPagos();
        }
        public bool agregarPago(entFormaPago formapago)
        {
            return datFormaPago.Instancia.agregarFormaPago(formapago);
        }

        public bool deshabilitarPago(int id)
        {
            return datFormaPago.Instancia.deshabilitarFormaPago(id);
        }
        public bool actualizarPago(entFormaPago pago)
        {
            return datFormaPago.Instancia.actualizarPago(pago);
        }
    }
}