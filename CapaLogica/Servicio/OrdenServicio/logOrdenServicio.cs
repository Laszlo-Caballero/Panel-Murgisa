using CapaAccesoDatos.Servicio.OrdenServicio;
using CapaEntidad.Servicio.OrdenServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicio.OrdenServicio
{
    public class logOrdenServicio
    {
        private static readonly logOrdenServicio _instancia = new logOrdenServicio();

        public static logOrdenServicio Instancia
        {
            get { return _instancia; }
        }
        public List<entOrdenServicioVista> listarOrdenServicio()
        {
            return datOrdenServicio.Instancia.listarOrdenServicio();
        }

        public bool agregarOrdenServicio(entOrdenServicio nuevo)
        {
            return datOrdenServicio.Instancia.agregarOrdenServicio(nuevo);
        }


        public bool deshablitarOrdenServicio(int id)
        {
            return datOrdenServicio.Instancia.deshabilitarOrdenServicio(id);
        }
    }
}