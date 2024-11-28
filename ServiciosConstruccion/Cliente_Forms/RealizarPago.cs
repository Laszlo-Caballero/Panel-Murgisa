using CapaEntidad.Cliente;
using CapaEntidad.PagoServicio;
using CapaLogica.Cliente;
using CapaLogica.PagoServicio;
using CapaLogica.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class RealizarPago : Form
    {
        public RealizarPago()
        {
            InitializeComponent();
            listarDatos();
            listarPago();
        }

        public void listarDatos()
        {
            cbCliente.DataSource = logCliente.Instancia.listarClientes();
            cbCliente.DisplayMember = "nombreRepresentatne";
            cbFormaPago.DataSource = logFormaPago.Instancia.listarPagos();
            cbFormaPago.DisplayMember = "tipo";
        }

        public void listarPago()
        {
            dgvPago.DataSource = logPagoServicio.Instancia.listarPagoServicio();
        }



        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            entCliente cliente = cbCliente.SelectedValue as entCliente;
            txtDni.Text = cliente.dni;
            txtCorreo.Text = cliente.correo;
        }

        private void bttnAgrupar_Click(object sender, EventArgs e)
        {
            entPagoServicio pago = new entPagoServicio();
            entFormaPago formaPago = cbFormaPago.SelectedValue as entFormaPago;

            pago.idVenta = Convert.ToInt32(txtIdVenta.Text);
            pago.fecha = dtPago.Value;
            pago.idFormaPago = formaPago.idFormaPago;
            pago.estado = true;

            bool estado = logPagoServicio.Instancia.agregarPagoServicio(pago);
            if (estado)
            {
                listarPago();
            }
            else
            {
                MessageBox.Show("Paso algo");
            }

        }

        private void dgvPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPago.Rows[e.RowIndex];

            txtIdServicio.Text = row.Cells[0].Value.ToString();

        }

        private void bttnAnular_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdServicio.Text);
            bool anular = logPagoServicio.Instancia.deshablitarPagoServicio(id);
            if (anular)
            {
                listarPago();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDni.Text;
            dgvPago.DataSource = logPagoServicio.Instancia.listarPagoServicioDni(dni);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarPago();
        }
    }
}
