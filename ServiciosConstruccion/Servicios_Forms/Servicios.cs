using CapaEntidad.Servicio.Servicios;
using CapaLogica.Servicio.Servicios;
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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
            listarServicios();
        }

        public void listarServicios()
        {
            dtServicio.DataSource = logServicios.Instancia.listarServicios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entServicios servicio = new entServicios();
            servicio.nombre = txtNombre.Text;
            servicio.precio = float.Parse(txtPrecio.Text);
            servicio.estado = cbkEstado.Checked;
            bool agregar = logServicios.Instancia.agregarServicios(servicio);
            if (agregar)
            {
                listarServicios();
            }
            else
            {
                MessageBox.Show("No se agrego");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            entServicios servicio = new entServicios();
            servicio.idServicio = Convert.ToInt32(txtId.Text);
            servicio.nombre = txtNombre.Text;
            servicio.precio = float.Parse(txtPrecio.Text);
            servicio.estado = cbkEstado.Checked;
            bool actualizar = logServicios.Instancia.actualizarServicios(servicio);
            if (actualizar)
            {
                listarServicios();
            }
            else
            {
                MessageBox.Show("No se actualizo");
            }
        }

        private void btnDeshabilita_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            bool deshabilitar = logServicios.Instancia.deshablitarServicio(id);
            if (deshabilitar)
            {
                listarServicios();
            }
            else
            {
                MessageBox.Show("No se deshabilito");
            }
        }

        private void dtServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtServicio.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtPrecio.Text = row.Cells[2].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(row.Cells[3].Value);
        }
    }
}
