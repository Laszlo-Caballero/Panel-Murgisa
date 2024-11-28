using CapaAccesoDatos.Servicio.PagoServicio;
using CapaEntidad.Servicio.PagoServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio.PagoServicio
{
    public class logPagoServicio
    {
        private static readonly logPagoServicio _instancia = new logPagoServicio();

        public static logPagoServicio Instancia
        {
            get { return _instancia; }
        }
        public List<entPagoServicio> listarPagoServicio()
        {
            return datPagoServicio.Instancia.listarPagoServicio();
        }

        public bool agregarPagoServicio(entPagoServicio nuevo)
        {
            return datPagoServicio.Instancia.agregarPagoServicio(nuevo);
        }

        public bool deshablitarPagoServicio(int id)
        {
            return datPagoServicio.Instancia.deshabilitarPagoServicio(id);
        }
        public List<entPagoServicio> listarPagoServicioDni(string dni)
        {
            return datPagoServicio.Instancia.listarPagoServicioDni(dni);
        }
    }
}