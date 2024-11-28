using CapaEntidad.Proveedor;
using CapaEntidad.Recurso;
using CapaLogica.Recurso;
using CapaLogica.TipoMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento_Forms
{
    public partial class PedidoMantenimientoCorrectivo : Form
    {
        public PedidoMantenimientoCorrectivo()
        {
            InitializeComponent();
            listarDatos();
        }

        public void listarDatos()
        {
            cbMantenimiento.DataSource = logTipoMan.Instancia.listarTipoMan();
            cbMantenimiento.DisplayMember = "tipo";
            cbMaquinaria.DataSource = logRecurso.Instancia.listarMaquinaria();
            cbMaquinaria.DisplayMember = "nombre";
        }

    }
}
