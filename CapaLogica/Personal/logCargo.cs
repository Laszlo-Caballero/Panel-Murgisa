using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Personal
{
    public class logCargo
    {
        private static readonly logCargo _instancia = new logCargo();

        public static logCargo Instancia
        {
            get { return _instancia; }
        }
        public List<entCargo> listarCargo()
        {
            return datCargo.Instancia.listarCargo();
        }

        public bool agregarCargo(entCargo nuevo)
        {
            return datCargo.Instancia.agregarCargo(nuevo);
        }

        public bool actualizarCargo(entCargo nuevo)
        {
            return datCargo.Instancia.actualizarCargo(nuevo);
        }

        public bool deshablitarCargo(int id)
        {
            return datCargo.Instancia.deshabilitarCargo(id);
        }
    }
}