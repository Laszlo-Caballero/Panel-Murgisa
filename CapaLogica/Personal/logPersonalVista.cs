using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Personal
{
    public class logPersonalVista
    {
        private static readonly logPersonalVista _instancia = new logPersonalVista();

        public static logPersonalVista Instancia
        {
            get { return _instancia; }
        }
        public List<entPersonalVista> listarPersonal()
        {
            return datPersonalVista.Instancia.listarPersonal();
        }
    }
}
