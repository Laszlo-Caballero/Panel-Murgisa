using CapaAccesoDatos.PagoServicio;
using CapaEntidad.PagoServicio;
using CapaLogica.PagoServicio;
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
    public partial class FormadePago : Form
    {
        public FormadePago()
        {
            InitializeComponent();
            listarForma();
        }

        private void listarForma()
        {
            dgForma.DataSource = logFormaPago.Instancia.listarPagos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = txtFormaPago.Text;
            bool estado = cbkForma.Checked;
            entFormaPago entFormaPago = new entFormaPago();
            entFormaPago.tipo = tipo;
            entFormaPago.estado = estado;
            bool agregar = logFormaPago.Instancia.agregarPago(entFormaPago);
            if (agregar)
            {
                listarForma();
            }
            else
            {
                MessageBox.Show("No se inserto");
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            bool deshabilitar = logFormaPago.Instancia.deshabilitarPago(id);
            if (deshabilitar)
            {
                listarForma();
            }
            else
            {
                MessageBox.Show("No se deshabilitar");
            }
        }

        private void dgForma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgForma.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtFormaPago.Text = filaActual.Cells[1].Value.ToString();
            cbkForma.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string tipo = txtFormaPago.Text;
            bool estado = cbkForma.Checked;

            entFormaPago pago = new entFormaPago();
            pago.idFormaPago = id;
            pago.tipo = tipo;
            pago.estado = estado;
            bool actualizar = logFormaPago.Instancia.actualizarPago(pago);

            if (actualizar)
            {
                listarForma();
            }
            else
            {
                MessageBox.Show("No se deshabilito");
            }
        }

    }
}
