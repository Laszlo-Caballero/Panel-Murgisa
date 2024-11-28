using CapaAccesoDatos.Usuario;
using CapaEntidad.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Usuario
{
    public class logUsuario
    {
        private static readonly logUsuario _instancia = new logUsuario();

        public static logUsuario Instancia
        {
            get { return _instancia; }
        }

        public List<entUsuario> ListarUsuarios()
        {
            return datUsuario.Instancia.ListarUsuarios();
        }
        public entUsuario logear(string usuario, string contrasena)
        {

            return datUsuario.Instancia.logear(usuario,contrasena);
        }
    }
}
