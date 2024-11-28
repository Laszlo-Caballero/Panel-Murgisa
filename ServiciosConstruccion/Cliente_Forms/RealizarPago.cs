using CapaEntidad.Cliente;
using CapaLogica.Cliente;
using CapaLogica.FormaPago;
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
            dgvPago.DataSource = logFormaPago.Instancia.listarPagos();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            entCliente cliente = cbCliente.SelectedValue as entCliente;
            cbVenta.DataSource = logVenta.Instancia.listarVentaCliente(cliente.idCliente);
            cbVenta.DisplayMember = "id";
            txtDni.Text = cliente.dni; 
            txtCorreo.Text = cliente.correo;
        }
    }
}
