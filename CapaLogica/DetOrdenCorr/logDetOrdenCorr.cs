using CapaAccesoDatos.PedidoManCor;
using CapaEntidad.PedidoManCor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.DetOrdenCorr
{
    public class logDetOrdenCorr
    {
        private static readonly logDetOrdenCorr _instancia = new logDetOrdenCorr();

        public static logDetOrdenCorr Instancia
        {
            get { return _instancia; }
        }
 

        public bool agregarDetOrdenCorr(entDetOrdenCorr nuevo)
        {
            return datDetOrdenCorr.Instancia.agregarDetOrdenCorr(nuevo);
        }

        public bool actualizarDetOrdenCorr(entDetOrdenCorr nuevo)
        {
            return datDetOrdenCorr.Instancia.actualizarDetOrdenCorr(nuevo);
        }

        public bool deshablitarDetOrdenCorr(int id)
        {
            return datDetOrdenCorr.Instancia.deshabilitarDetOrdenCorr(id);
        }
    }
}