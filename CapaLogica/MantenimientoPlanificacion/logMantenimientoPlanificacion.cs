using CapaAccesoDatos.MantenimientoPlanificacion;
using CapaEntidad.MantenimientoPlanificacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.MantenimientoPlanificacion
{
    public class logMantenimientoPlanificacion
    {
        private static readonly logMantenimientoPlanificacion _instancia = new logMantenimientoPlanificacion();

        public static logMantenimientoPlanificacion Instancia
        {
            get { return _instancia; }
        }
        public DataTable listarMantenimientoPlanificacionParaGrid(int? idPlanificacion = null, DateTime? fechaMantenimiento = null)
        {
            return datMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacionParaGrid(idPlanificacion,fechaMantenimiento);
        }  
        public bool existeMantenimientoPorPersonalYHorario(int IdPersonal, int IdHorario)
        {
            return datMantenimientoPlanificacion.Instancia.existeMantenimientoPorPersonalYHorario(IdPersonal, IdHorario);
        }  
        public List<entMantenimientoPlanificacion> listarMantenimientoPlanificacion()
        {
            return datMantenimientoPlanificacion.Instancia.listarMantenimientoPlanificacion();
        }
        public entMantenimientoPlanificacion buscarPorId(int id)
        {
            return datMantenimientoPlanificacion.Instancia.buscarPorId(id);
        }
        public bool desabilitarMatenimientoPlanificacion(int id)
        {
            return datMantenimientoPlanificacion.Instancia.desabilitarMatenimientoPlanificacion(id);
        }
        public bool agregarMantenimientoPlanificacion(entMantenimientoPlanificacion nuevo)
        {
            return datMantenimientoPlanificacion.Instancia.agregarMantenimientoPlanificacion(nuevo);
        }

        public bool actualizarMantenimientoPlanificacion(entMantenimientoPlanificacion nuevo)
        {
            return datMantenimientoPlanificacion.Instancia.actualizarMantenimientoPlanificacion(nuevo);
        }

        public bool deshablitarMantenimientoPlanificacion(int id)
        {
            return datMantenimientoPlanificacion.Instancia.deshabilitarMantenimientoPlanificacion(id);
        }
    }
}