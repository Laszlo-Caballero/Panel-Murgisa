using System;
namespace CapaEntidad.OrdenMantenimientoPreventivo
{
    public class entOrdenMantenimientoPreventivo
    {
        public int idOrdenMantenimiento { get; set; }
        public int? idPlanificacion { get; set; }
        public DateTime? fecha { get; set; }
        public bool? estado { get; set; }
    }
}
