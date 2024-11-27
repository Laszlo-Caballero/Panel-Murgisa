using CapaEntidad.Cliente;
using CapaEntidad.Condicion;
using CapaLogica.Cliente;
using CapaLogica.Condicion;
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
    public partial class Condicion : Form
    {
        public Condicion()
        {
            InitializeComponent();
            ListarCondicion();
        }
        private void ListarCondicion()
        {
            dgvCondicion.DataSource = logCondicion.Instancia.listarCondicion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtCondicion.Text;
            bool estado = cbEstado.Checked;

            entCondicion condicion = new entCondicion();

            condicion.condicion = nombre;
            condicion.estado = estado;

            bool ingreso = logCondicion.Instancia.agregarCondicion(condicion);

            if (ingreso)
            {
                ListarCondicion();
            }
            else
            {
                MessageBox.Show("error al insertar clientes");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCondicion.Text);
            string nombre = txtCondicion.Text;
            bool estado = cbEstado.Checked;
            entCondicion condicion = new entCondicion();

            condicion.idCondicion = id;
            condicion.condicion = nombre;
            condicion.estado = estado;


            bool estadoActualizar = logCondicion.Instancia.actualizarCondicion(condicion);
            if (estadoActualizar)
            {
                ListarCondicion();
            }

        }
        private void LimpiarVariables()
        {
            txtCondicion.Text = "";
            cbEstado.Checked = false;
        }
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCondicion c = new entCondicion();
                c.idCondicion = int.Parse(txtIdCondicion.Text.Trim());
                cbEstado.Checked = false;
                c.estado = cbEstado.Checked;
                logCondicion.Instancia.deshablitarCondicion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            dgvCondicion.Enabled = false;
            ListarCondicion();
        }
    }
}
