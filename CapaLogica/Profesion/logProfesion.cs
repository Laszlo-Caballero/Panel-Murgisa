using CapaAccesoDatos.Profesion;
using CapaEntidad.Profesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Profesion
{
    public class logProfesion
    {
        private static readonly logProfesion _instancia = new logProfesion();

        public static logProfesion Instancia
        {
            get { return _instancia; }
        }
        public List<entProfesion> listarProfesion()
        {
            return datProfesion.Instancia.listarProfesion();
        }

        public bool agregarProfesion(entProfesion nuevo)
        {
            return datProfesion.Instancia.agregarProfesion(nuevo);
        }

        public bool actualizarProfesion(entProfesion nuevo)
        {
            return datProfesion.Instancia.actualizarProfesion(nuevo);
        }

        public bool deshablitarProfesion(int id)
        {
            return datProfesion.Instancia.deshabilitarProfesion(id);
        }
    }
}