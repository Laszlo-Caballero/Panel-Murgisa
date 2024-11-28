using CapaAccesoDatos.Horario;
using CapaEntidad.Horario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Horario
{
    public class logHorario
    {
        private static readonly logHorario _instancia = new logHorario();

        public static logHorario Instancia
        {
            get { return _instancia; }
        }
        public DataTable listarHorarioActivo()
        {
            return datHorario.Instancia.listarHorarioActivo();
        }

        public bool agregarHorario(entHorario nuevo)
        {
            return datHorario.Instancia.agregarHorario(nuevo);
        }

        public bool actualizarHorario(entHorario nuevo)
        {
            return datHorario.Instancia.actualizarHorario(nuevo);
        }

        public bool deshablitarHorario(int id)
        {
            return datHorario.Instancia.deshabilitarHorario(id);
        }
    }
}