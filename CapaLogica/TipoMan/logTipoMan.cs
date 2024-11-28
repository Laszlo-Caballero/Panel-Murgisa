using CapaAccesoDatos.TipoMan;
using CapaEntidad.TipoMan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.TipoMan
{
    public class logTipoMan
    {
        private static readonly logTipoMan _instancia = new logTipoMan();

        public static logTipoMan Instancia
        {
            get { return _instancia; }
        }
        public DataTable listarTipoManDT()
        {
            return datTipoMan.Instancia.listarTipoManDT();
        }
        public List<entTipoMan> listarTipoMan()
        {
            return datTipoMan.Instancia.listarTipoMan();
        }

        public bool agregarTipoMan(entTipoMan nuevo)
        {
            return datTipoMan.Instancia.agregarTipoMan(nuevo);
        }

        public bool actualizarTipoMan(entTipoMan nuevo)
        {
            return datTipoMan.Instancia.actualizarTipoMan(nuevo);
        }

        public bool deshablitarTipoMan(int id)
        {
            return datTipoMan.Instancia.deshabilitarTipoMan(id);
        }
    }
}