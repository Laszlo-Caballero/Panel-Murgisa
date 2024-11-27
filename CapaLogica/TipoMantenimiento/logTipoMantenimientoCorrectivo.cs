using CapaAccesoDatos.TipoMantenimiento;
using CapaEntidad.TipoMantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.TipoMantenimiento
{
    public class logTipoMantenimientoCorrectivo
    {
        private static readonly logTipoMantenimientoCorrectivo _instancia = new logTipoMantenimientoCorrectivo();

        public static logTipoMantenimientoCorrectivo Instancia
        {
            get { return _instancia; }
        }
        public List<entTipoMantenimientoCorrectivo> listarTipoMantenimientoCorrectivo()
        {
            return datTipoMantenimientoCorrectivo.Instancia.listarTipoMantenimientoCorrectivo();
        }

        public bool agregarTipoMantenimientoCorrectivo(entTipoMantenimientoCorrectivo nuevo)
        {
            return datTipoMantenimientoCorrectivo.Instancia.agregarTipoMantenimientoCorrectivo(nuevo);
        }

        public bool actualizarTipoMantenimientoCorrectivo(entTipoMantenimientoCorrectivo nuevo)
        {
            return datTipoMantenimientoCorrectivo.Instancia.actualizarTipoMantenimientoCorrectivo(nuevo);
        }

        public bool deshablitarTipoMantenimientoCorrectivo(int id)
        {
            return datTipoMantenimientoCorrectivo.Instancia.deshabilitarTipoMantenimientoCorrectivo(id);
        }
    }
}