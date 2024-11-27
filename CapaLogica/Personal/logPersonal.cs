using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Personal
{
    public class logPersonal
    {
        private static readonly logPersonal _instancia = new logPersonal();

        public static logPersonal Instancia
        {
            get { return _instancia; }
        }
        public List<entPersonal> listarPersonal()
        {
            return datPersonal.Instancia.listarPersonal();
        }

        public bool agregarPersonal(entPersonal nuevo)
        {
            return datPersonal.Instancia.agregarPersonal(nuevo);
        }

        public bool actualizarPersonal(entPersonal nuevo)
        {
            return datPersonal.Instancia.actualizarPersonal(nuevo);
        }

        public bool deshablitarPersonal(int id)
        {
            return datPersonal.Instancia.deshabilitarPersonal(id);
        }
    }
}