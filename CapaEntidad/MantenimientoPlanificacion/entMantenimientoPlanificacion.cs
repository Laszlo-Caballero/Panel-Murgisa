using System;

namespace CapaEntidad.MantenimientoPlanificacion
{
    public class entMantenimientoPlanificacion
    {
        public int IdPlanificacion { get; set; }
        public int? IdRecurso { get; set; }
        public int? IdPersonal { get; set; }
        public int? IdHorario { get; set; }
        public int? IdTipoMantenimiento { get; set; }
        public DateTime? FechaMantenimiento { get; set; }
        public string? Prioridad { get; set; }
        public bool? Estado { get; set; }
    }
}
