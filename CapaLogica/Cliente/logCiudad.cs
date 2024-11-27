using CapaAccesoDatos.Cliente;
using CapaEntidad.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Cliente
{
    public class logCiudad
    {
        private static readonly logCiudad _instacia = new logCiudad();

        public static logCiudad Instacia
        {
            get { return _instacia; }
        }

        public List<entCiudad> listarCiudad()
        {
            return datCiudad.Instancia.listarCiudad();
        }
    }
}
