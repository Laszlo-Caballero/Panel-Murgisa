using CapaAccesoDatos.Personal;
using CapaEntidad.Mantenimiento.PedidoManCor;
using CapaEntidad.Mantenimiento.TipoMan;
using CapaEntidad.Personal;
using CapaEntidad.Recurso.Proveedor;
using CapaEntidad.Recurso;
using CapaLogica.Mantenimiento.PedidoManCor;
using CapaLogica.Mantenimiento.TipoMan;
using CapaLogica.Personal;
using CapaLogica.Recurso;
using CapaPresentacion.Personal_Forms;
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
        private List<entDetPedidoCorr> detalle = new List<entDetPedidoCorr>();
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



        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            entTipoMan mantenimiento = cbMantenimiento.SelectedItem as entTipoMan;
            string id = mantenimiento.id.ToString();
            string nombre = mantenimiento.tipo;

            entDetPedidoCorr pedido = new entDetPedidoCorr();
            pedido.mantenimiento = mantenimiento.id;
            pedido.estado = true;
            detalle.Add(pedido);

            ListViewItem items = new ListViewItem(id);
            items.SubItems.Add(nombre);
            listaDetalle.Items.Add(items);
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            entRecurso maquinaria = cbMaquinaria.SelectedItem as entRecurso;

            entPedidoManCor pedido = new entPedidoManCor();
            pedido.recurso = maquinaria.idRecurso;
            pedido.fecha = dtpFecha.Value;
            pedido.estado = cbEstado.Checked;

            bool estado = logDetPedidoCor.Instancia.agregarDetOrdenCorr(pedido.recurso, pedido, detalle);
            if (!estado)
                MessageBox.Show("Error al ingresar pedido");
            else
            {
                listarPedidos();
                detalle = new List<entDetPedidoCorr>();
                listaDetalle.Items.Clear();

            }
        }

        private void dgvpedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvpedido.Rows[e.RowIndex];
            txtPedido.Text = filaActual.Cells[0].Value.ToString();
            int selec = Convert.ToInt32(filaActual.Cells[1].Value);
            cbMaquinaria.SelectedItem = cbMaquinaria.Items.Cast<entRecurso>().FirstOrDefault(item => item.idRecurso == selec);
            dtpFecha.Value = Convert.ToDateTime(filaActual.Cells[3].Value);
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void txtDeshabilitar_Click(object sender, EventArgs e)
        {
            entPedidoManCor pedido = new entPedidoManCor();
            pedido.id = Convert.ToInt32(txtPedido.Text);
            bool deshabilitar = logPedidoManCor.Instancia.deshablitarPedidoManCor(pedido.id);

            if (deshabilitar)
            {
                listarPedidos();
                txtPedido.Text = "";
            }
            else
                MessageBox.Show("error al deshabilitar cargo");
        }

        
    }
}
