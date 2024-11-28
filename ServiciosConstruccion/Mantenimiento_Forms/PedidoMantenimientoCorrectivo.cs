using CapaEntidad.Proveedor;
using CapaEntidad.Recurso;
using CapaEntidad.TipoMan;
using CapaLogica.PedidoManCor;
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
            listarPedidos();
        }

        public void listarPedidos()
        {
            dgvpedido.DataSource = logPedidoManCor.Instancia.listarPedidoManCor();
        }

        public void listarDatos()
        {
            cbMantenimiento.DataSource = logTipoMan.Instancia.listarTipoMan();
            cbMantenimiento.DisplayMember = "tipo";
            cbMaquinaria.DataSource = logRecurso.Instancia.listarMaquinaria();
            cbMaquinaria.DisplayMember = "nombre";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            entTipoMan mantenimiento = cbMantenimiento.SelectedItem as entTipoMan;
            string id = mantenimiento.id.ToString();
            string nombre = mantenimiento.tipo;

            ListViewItem items = new ListViewItem(id);
            items.SubItems.Add(nombre);
            listaDetalle.Items.Add(items);
        }
    }
}
