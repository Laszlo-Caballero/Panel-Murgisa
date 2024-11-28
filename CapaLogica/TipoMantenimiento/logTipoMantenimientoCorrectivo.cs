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
        public List<entTipoMantenimiento> listarTipoMantenimientoCorrectivo()
        {
            return datTipoMantenimientoCorrectivo.Instancia.listarTipoMantenimientoCorrectivo();
        }

        public bool agregarTipoMantenimientoCorrectivo(entTipoMantenimiento nuevo)
        {
            return datTipoMantenimientoCorrectivo.Instancia.agregarTipoMantenimientoCorrectivo(nuevo);
        }

        public bool actualizarTipoMantenimientoCorrectivo(entTipoMantenimiento nuevo)
        {
            return datTipoMantenimientoCorrectivo.Instancia.actualizarTipoMantenimientoCorrectivo(nuevo);
        }

        public bool deshablitarTipoMantenimientoCorrectivo(int id)
        {
            return datTipoMantenimientoCorrectivo.Instancia.deshabilitarTipoMantenimientoCorrectivo(id);
        }
    }
}