using CapaAccesoDatos.Repuesto;
using CapaEntidad.Repuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Repuesto
{
    public class logRepuesto
    {
        private static readonly logRepuesto _instancia = new logRepuesto();

        public static logRepuesto Instancia
        {
            get { return _instancia; }
        }
        public List<entRepuesto> listarRepuesto()
        {
            return datRepuesto.Instancia.listarRepuesto();
        }

        public bool agregarRepuesto(entRepuesto nuevo)
        {
            return datRepuesto.Instancia.agregarRepuesto(nuevo);
        }

        public bool actualizarRepuesto(entRepuesto nuevo)
        {
            return datRepuesto.Instancia.actualizarRepuesto(nuevo);
        }

        public bool deshablitarRepuesto(int id)
        {
            return datRepuesto.Instancia.deshabilitarRepuesto(id);
        }
    }
}