using CapaAccesoDatos.Personal;
using CapaEntidad.Personal;
using System.Data;

namespace CapaLogica.Personal
{
    public class logPersonal
    {
        private static readonly logPersonal _instancia = new logPersonal();

        public static logPersonal Instancia
        {
            get { return _instancia; }
        }
        public  DataTable listarPersonalTecnico()
        {
            return datPersonal.Instancia.listarPersonalTecnico();
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