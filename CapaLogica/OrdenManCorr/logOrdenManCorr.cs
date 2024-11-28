using CapaAccesoDatos.OrdenManCorr;
using CapaEntidad.OrdenManCorr;
using CapaLogica.PedidoManCor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.OrdenManCorr
{
    public class logOrdenManCorr
    {
        private static readonly logOrdenManCorr _instancia = new logOrdenManCorr();

        public static logOrdenManCorr Instancia
        {
            get { return _instancia; }
        }
        public List<entOrdenManCorr> listarOrdenManCorr()
        {
            return datOrdenManCorr.Instancia.listarOrdenManCorr();
        }

        public bool agregarOrdenManCorr(entOrdenManCorr nuevo, int id)
        {
            logPedidoManCor.Instancia.deshablitarPedidoManCor(id);
            return datOrdenManCorr.Instancia.agregarOrdenManCorr(nuevo);
        }
        public bool deshablitarOrdenManCorr(int id)
        {
            return datOrdenManCorr.Instancia.deshabilitarOrdenManCorr(id);
        }
    }
}