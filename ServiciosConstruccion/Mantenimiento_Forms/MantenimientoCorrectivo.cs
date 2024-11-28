using CapaEntidad.OrdenManCorr;
using CapaEntidad.PedidoManCor;
using CapaEntidad.Proveedor;
using CapaEntidad.Recurso;
using CapaLogica.OrdenManCorr;
using CapaLogica.PedidoManCor;
using CapaLogica.Proveedor;
using CapaLogica.Recurso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion.Mantenimiento_Forms
{
    public partial class MantenimientoCorrectivo : Form
    {
        public MantenimientoCorrectivo()
        {
            InitializeComponent();
            listarOrden();
            listarDatos();
        }
        public void listarOrden()
        {
            dgvOrdenMan.DataSource = logOrdenManCorr.Instancia.listarOrdenManCorr();
        }

        public void listarDatos()
        {
            cbPedido.DataSource = logPedidoManCor.Instancia.listarPedidoManCor();
            cbPedido.DisplayMember = "id";
        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            entPedidoManCor pedido = cbPedido.SelectedItem as entPedidoManCor;
            txtMaquinaria.Text = pedido.nombre;
            entRecurso recurso = logRecurso.Instancia.buscarMaquinaria(pedido.recurso);
            txtMaquinaria.Text = recurso.nombre;
            entProveedor proveedor = logProveedor.Instancia.buscarProveedor(recurso.idProveedor);
            txtProveedor.Text = proveedor.razsocial;
            txtRuc.Text = proveedor.ruc;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            entPedidoManCor pedido = cbPedido.SelectedItem as entPedidoManCor;
            entOrdenManCorr orden = new entOrdenManCorr();
            orden.pedido = pedido.id;
            orden.estado = cbEstado.Checked;
            orden.fecha = dtPickerFechaMc.Value;

            bool estado = logOrdenManCorr.Instancia.agregarOrdenManCorr(orden, orden.pedido);
            if (!estado)
                MessageBox.Show("Error al ingresar orden");
            else
            {
                listarOrden();
                limpiar();
                listarDatos();
            }

        }

        public void limpiar()
        {
            txtMaquinaria.Text = "";
            txtProveedor.Text = "";
            txtRuc.Text = "";
        }
    }
}
