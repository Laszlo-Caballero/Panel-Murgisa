using System;
namespace CapaEntidad.OrdenMantenimientoPreventivo
{
    public class entOrdenMantenimientoPreventivo
    {
        public int idOrdenMantenimiento { get; set; }
        public int? idPlanificacion { get; set; }
        public string? ResultadoEjecucion { get; set; }
        public string? Comentarios { get; set; }
        public string? RequerimientosEspeciales { get; set; }
        public double? DuracionEstimadaHoras { get; set; }
        public DateTime? fecha { get; set; }
        public bool? estado { get; set; }
    }
}
