using CapaAccesoDatos.Cliente;
using CapaAccesoDatos.Recurso.Condicion;
using CapaEntidad.Cliente;
using CapaEntidad.Recurso.Condicion;
using CapaEntidad.Personal;
using CapaLogica.Cliente;
using CapaLogica.Recurso.Condicion;
using CapaLogica.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Personal_Forms
{
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            dgvCargo.DataSource = logCargo.Instancia.listarCargo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entCargo cargo = new entCargo();
            cargo.cargo = txtNombre.Text;
            cargo.desc = txtDesc.Text;
            cargo.estado = cbkEstado.Checked;

            bool agregar = logCargo.Instancia.agregarCargo(cargo);

            if (agregar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al insertar cargo");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entCargo cargo = new entCargo();
            cargo.id = Convert.ToInt32(txtCargo.Text);
            cargo.cargo = txtNombre.Text;
            cargo.desc = txtDesc.Text;
            cargo.estado = cbkEstado.Checked;

            bool editar = logCargo.Instancia.actualizarCargo(cargo);
            if (editar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al actualizar cargo");
        }

        private void dgvCargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCargo.Rows[e.RowIndex];
            txtCargo.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDesc.Text = filaActual.Cells[2].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        public void limpiar()
        {
            txtCargo.Text = "";
            txtNombre.Text = "";
            txtDesc.Text = "";
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            entCargo cargo = new entCargo();
            cargo.id = Convert.ToInt32(txtCargo.Text);
            bool deshabilitar = logCargo.Instancia.deshablitarCargo(cargo.id);

            if (deshabilitar)
            {
                listar();
                limpiar();
            }
            else
                MessageBox.Show("error al deshabilitar cargo");
        }


    }
}
