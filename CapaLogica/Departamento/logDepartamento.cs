using CapaAccesoDatos.Departamento;
using CapaEntidad.Departamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Departamento
{
    public class logDepartamento
    {
        private static readonly logDepartamento _instancia = new logDepartamento();

        public static logDepartamento Instancia
        {
            get { return _instancia; }
        }
        public List<entDepartamento> listarDepartamento()
        {
            return datDepartamento.Instancia.listarDepartamento();
        }

        public bool agregarDepartamento(entDepartamento nuevo)
        {
            return datDepartamento.Instancia.agregarDepartamento(nuevo);
        }

        public bool actualizarDepartamento(entDepartamento nuevo)
        {
            return datDepartamento.Instancia.actualizarDepartamento(nuevo);
        }

        public bool deshablitarServicio(int id)
        {
            return datDepartamento.Instancia.deshabilitarDepartamento(id);
        }
    }
}