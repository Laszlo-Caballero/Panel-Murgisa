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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            listarVentas();
        }

        public void listarVentas()
        {
            dtVentas.DataSource = logVenta.Instancia.listarVenta();
        }

        private void dtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtVentas.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            txtIdVenta.Text = id.ToString();
            dtMateriales.DataSource = logVenta.Instancia.listarDetalleVentas(id);
            dtEmpleados.DataSource = logVenta.Instancia.listarPersonal(id);
        }

        private void btnsultar_Click(object sender, EventArgs e)
        {
            string dni = txtRuc.Text;
            dtVentas.DataSource = logVenta.Instancia.listarVentaCliente(dni);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            listarVentas();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }
    }
}
