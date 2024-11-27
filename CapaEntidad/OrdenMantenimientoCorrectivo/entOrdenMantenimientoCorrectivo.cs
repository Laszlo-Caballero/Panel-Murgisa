using System;

namespace CapaEntidad.OrdenMantenimientoCorrectivo
{
    public class entOrdenMantenimientoCorrectivo
    {
        public int idOrdenManCor { get; set; }
        public int? idPedido { get; set; }
        public bool? estado { get; set; }
        public DateTime? fecha { get; set; }
    }
}
