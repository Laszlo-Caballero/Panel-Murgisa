using CapaEntidad.PedidoManCor;
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

            bool estado = logDetPedidoCor.Instancia.agregarDetOrdenCorr(pedido, detalle);
            if (!estado)
                MessageBox.Show("Error al ingresar pedido");
            else
            {
                listarPedidos();
                detalle = new List<entDetPedidoCorr>();
                listaDetalle.Items.Clear();

            }
        }
    }
}
